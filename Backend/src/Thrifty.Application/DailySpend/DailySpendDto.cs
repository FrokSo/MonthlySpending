namespace Thrifty.Application.DailySpend
{
    // Total expenses for one day. Computed from transactions, so there is no entity to map from.
    public class DailySpendDto
    {
        public DateOnly Date { get; }

        public decimal Amount { get; }

        public DailySpendDto(DateOnly date, decimal amount)
        {
            Date = date;
            Amount = amount;
        }
    }
}
