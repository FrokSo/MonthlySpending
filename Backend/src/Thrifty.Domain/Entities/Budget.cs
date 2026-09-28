using Thrifty.Domain.Enums;

namespace Thrifty.Domain.Entities
{
    // A spending limit for one category in one calendar month.
    // Spent amount and status are derived from transactions, so they are not stored here.
    public class Budget
    {
        public int Id { get; set; }

        public CategoryId Category { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public decimal Limit { get; set; }
    }
}
