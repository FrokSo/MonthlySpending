using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Application.Abstractions;

namespace Thrifty.Application.Budgets
{
    internal class BudgetServices
    {
        private readonly ITransactionRepository _transactions;

        public BudgetServices(ITransactionRepository transactions)
        {
            _transactions = transactions;
        }

        public List<BudgetDto> GetBudgetCategory(string monthYear)
        {
            return new List<BudgetDto>();
        }
    }
}
