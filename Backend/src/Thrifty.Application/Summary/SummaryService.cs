using Thrifty.Application.Abstractions;
using Thrifty.Domain.Entities;

namespace Thrifty.Application.Summary
{
    public class SummaryService
    {
        private readonly ITransactionRepository _transactions;
        private readonly IBudgetRepository _budgets;

        public SummaryService(ITransactionRepository transactions, IBudgetRepository budgets)
        {
            _transactions = transactions;
            _budgets = budgets;
        }

        public async Task<SummaryDto> GetSummaryAsync(int year, int month, CancellationToken cancellationToken = default)
        {
            var previousMonth = new DateOnly(year, month, 1).AddMonths(-1);

            // Awaited one at a time because a DbContext does not support parallel queries.
            var transactions = await _transactions.GetTransactionsByMonthAsync(year, month, cancellationToken);
            var previousTransactions = await _transactions.GetTransactionsByMonthAsync(previousMonth.Year, previousMonth.Month, cancellationToken);
            var budgets = await _budgets.GetByMonthAsync(year, month, cancellationToken);

            var income = transactions.Where(t => t.Amount > 0).Sum(t => t.Amount);
            var spent = GetTotalSpent(transactions);
            var previousSpent = GetTotalSpent(previousTransactions);
            var saved = income - spent;

            // Expense amounts are negative, so the lowest sum is the merchant with the highest spend.
            var topMerchant = transactions
                .Where(t => t.Amount < 0)
                .GroupBy(t => t.Merchant)
                .OrderBy(g => g.Sum(t => t.Amount))
                .FirstOrDefault();

            string? topMerchantName = null;
            decimal topMerchantAmount = 0;
            int topMerchantVisits = 0;

            if (topMerchant != null)
            {
                topMerchantName = topMerchant.Key;
                topMerchantAmount = -topMerchant.Sum(t => t.Amount);
                topMerchantVisits = topMerchant.Count();
            }

            return new SummaryDto(
                year,
                month,
                income,
                spent,
                budgets.Sum(b => b.Limit),
                GetPercentChange(spent, previousSpent),
                saved,
                GetPercentOf(saved, income),
                topMerchantName,
                topMerchantAmount,
                topMerchantVisits);
        }

        // Total expenses as a positive number.
        private static decimal GetTotalSpent(IEnumerable<Transaction> transactions)
        {
            return -transactions.Where(t => t.Amount < 0).Sum(t => t.Amount);
        }

        // Returns 0 when there is nothing to compare against, rather than dividing by zero.
        private static int GetPercentChange(decimal current, decimal previous)
        {
            if (previous == 0)
            {
                return 0;
            }

            return (int)Math.Round((current - previous) / previous * 100, MidpointRounding.AwayFromZero);
        }

        private static int GetPercentOf(decimal part, decimal whole)
        {
            if (whole == 0)
            {
                return 0;
            }

            return (int)Math.Round(part / whole * 100, MidpointRounding.AwayFromZero);
        }
    }
}
