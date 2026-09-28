using Thrifty.Domain.Entities;
using Thrifty.Domain.Enums;

namespace Thrifty.Infrastructure.Persistence.Seed
{
    // Ported from Frontend/src/data/mockData.ts. Applied through migrations via HasData.
    internal static class SeedData
    {
        public static readonly Transaction[] Transactions = new Transaction[]
        {
            new Transaction { Id = 1, Date = new DateOnly(2026, 9, 18), Merchant = "Din Tai Fung", Category = CategoryId.Food, PaymentMethod = "Credit card", Amount = -46.20m },
            new Transaction { Id = 2, Date = new DateOnly(2026, 9, 18), Merchant = "NTUC FairPrice", Category = CategoryId.Food, PaymentMethod = "PayNow", Amount = -62.35m },
            new Transaction { Id = 3, Date = new DateOnly(2026, 9, 17), Merchant = "Grab ride", Category = CategoryId.Transport, PaymentMethod = "Credit card", Amount = -14.80m },
            new Transaction { Id = 4, Date = new DateOnly(2026, 9, 15), Merchant = "SP Services", Category = CategoryId.Bills, PaymentMethod = "GIRO", Amount = -118.40m },
            new Transaction { Id = 5, Date = new DateOnly(2026, 9, 14), Merchant = "Uniqlo", Category = CategoryId.Shopping, PaymentMethod = "Credit card", Amount = -89.90m },
            new Transaction { Id = 6, Date = new DateOnly(2026, 9, 1), Merchant = "Salary", Category = CategoryId.Income, PaymentMethod = "Bank transfer", Amount = 5200m },
        };

        public static readonly Budget[] Budgets = new Budget[]
        {
            new Budget { Id = 1, Category = CategoryId.Food, Year = 2026, Month = 9, Limit = 750m },
            new Budget { Id = 2, Category = CategoryId.Housing, Year = 2026, Month = 9, Limit = 700m },
            new Budget { Id = 3, Category = CategoryId.Transport, Year = 2026, Month = 9, Limit = 400m },
            new Budget { Id = 4, Category = CategoryId.Shopping, Year = 2026, Month = 9, Limit = 300m },
            new Budget { Id = 5, Category = CategoryId.Bills, Year = 2026, Month = 9, Limit = 300m },
            new Budget { Id = 6, Category = CategoryId.Other, Year = 2026, Month = 9, Limit = 550m },
        };
    }
}
