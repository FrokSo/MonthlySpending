using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Application.Abstractions;

namespace Thrifty.Application.DailySpend
{
    public class DailySpendServices
    {
        private readonly ITransactionRepository _transactions;

        public DailySpendServices(ITransactionRepository transactions)
        {
            _transactions = transactions;
        }

        public List<DailySpendDto> GetDailySpend(int year, int month)
        {
            return new List<DailySpendDto>();
        }
    }
}
