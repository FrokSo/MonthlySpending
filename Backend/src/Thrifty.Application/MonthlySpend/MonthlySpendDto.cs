namespace Thrifty.Application.MonthlySpend
{
    // Total expenses for one calendar month. Computed from transactions, so there is no entity to map from.
    public class MonthlySpendDto
    {
        public int Year { get; }

        public int Month { get; }

        public decimal Amount { get; }

        public MonthlySpendDto(int year, int month, decimal amount)
        {
            Year = year;
            Month = month;
            Amount = amount;
        }
    }
}
