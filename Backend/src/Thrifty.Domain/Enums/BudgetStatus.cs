namespace Thrifty.Domain.Enums
{
    // Computed from spending against a budget's limit; never stored.
    public enum BudgetStatus
    {
        OnTrack,
        NearlyThere,
        OverBudget,
        Unused,
    }
}
