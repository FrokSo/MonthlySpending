namespace Thrifty.Application.Summary
{
    // Headline figures for one month, used by the Dashboard, Budgets and Reports pages.
    // Computed from transactions and budgets, so there is no entity to map from.
    public class SummaryDto
    {
        // The month this summary covers, formatted "yyyy-MM" (e.g. "2026-09").
        public string Month { get; }

        public decimal Income { get; }

        // Total expenses as a positive number.
        public decimal Spent { get; }

        // Sum of every category's budget limit for the month.
        public decimal Budget { get; }

        // Change in Spent versus the previous month, e.g. -6 means 6% less.
        public int VsLastMonthPercent { get; }

        // Income minus Spent. Negative when spending exceeds income.
        public decimal SavedThisMonth { get; }

        public int SavedPercentOfIncome { get; }

        // Merchant with the highest total spend. Null when the month has no expenses.
        public string? TopMerchant { get; }

        public decimal TopMerchantAmount { get; }

        public int TopMerchantVisits { get; }

        public SummaryDto(
            string month,
            decimal income,
            decimal spent,
            decimal budget,
            int vsLastMonthPercent,
            decimal savedThisMonth,
            int savedPercentOfIncome,
            string? topMerchant,
            decimal topMerchantAmount,
            int topMerchantVisits)
        {
            Month = month;
            Income = income;
            Spent = spent;
            Budget = budget;
            VsLastMonthPercent = vsLastMonthPercent;
            SavedThisMonth = savedThisMonth;
            SavedPercentOfIncome = savedPercentOfIncome;
            TopMerchant = topMerchant;
            TopMerchantAmount = topMerchantAmount;
            TopMerchantVisits = topMerchantVisits;
        }
    }
}
