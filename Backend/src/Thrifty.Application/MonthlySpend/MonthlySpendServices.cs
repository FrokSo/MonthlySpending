using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Application.Abstractions;

namespace Thrifty.Application.MonthlySpend
{
    internal class MonthlySpendServices
    {
        private readonly ITransactionRepository _transactions;

        public MonthlySpendServices(ITransactionRepository transactions)
        {
            _transactions = transactions;
        }

        public List<MonthlySpendDto> GetMonthlySpend(string monthYear)
        {
            return new List<MonthlySpendDto>();
        }
    }
}
