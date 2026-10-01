using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Application.Abstractions;

namespace Thrifty.Application.MonthlySpend
{
    public class MonthlySpendServices
    {
        private readonly ITransactionRepository _transactions;

        public MonthlySpendServices(ITransactionRepository transactions)
        {
            _transactions = transactions;
        }

        public List<MonthlySpendDto> GetMonthlySpend(int year, int month)
        {
            return new List<MonthlySpendDto>();
        }

        public IReadOnlyList<MonthlySpendDto> GetRangeMonthlySpend(int startYear, int startMonth, int endYear, int endMonth)
        {
            return new List<MonthlySpendDto>();
        }
    }
}
