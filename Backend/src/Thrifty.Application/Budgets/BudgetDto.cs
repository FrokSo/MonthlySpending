using Thrifty.Domain.Enums;

namespace Thrifty.Application.Budgets
{
    // Shape matches the BudgetCategory interface in Frontend/src/types/index.ts.
    public class BudgetDto
    {
        // Spending at or above this share of the limit counts as "nearly there".
        private const decimal NearlyThereThreshold = 0.9m;

        public CategoryId Category { get; }

        public decimal Spent { get; }

        public decimal Limit { get; }

        public BudgetStatus Status { get; }

        public BudgetDto(
            CategoryId category,
            decimal spent,
            decimal limit,
            BudgetStatus status)
        {
            Category = category;
            Spent = spent;
            Limit = limit;
            Status = status;
        }

        // Spent is not stored on the budget, so the caller totals the month's expenses for this category.
        // Fully qualified because this namespace is also called Budget.
        public static BudgetDto FromEntity(Thrifty.Domain.Entities.Budget budget, decimal spent)
        {
            return new BudgetDto(
                budget.Category,
                spent,
                budget.Limit,
                GetStatus(spent, budget.Limit));
        }

        private static BudgetStatus GetStatus(decimal spent, decimal limit)
        {
            if (spent == 0)
            {
                return BudgetStatus.Unused;
            }

            if (spent > limit)
            {
                return BudgetStatus.OverBudget;
            }

            if (spent >= limit * NearlyThereThreshold)
            {
                return BudgetStatus.NearlyThere;
            }

            return BudgetStatus.OnTrack;
        }
    }
}
