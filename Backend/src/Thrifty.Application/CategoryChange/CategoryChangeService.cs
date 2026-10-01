using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Application.Abstractions;

namespace Thrifty.Application.CategoryChange
{
    public class CategoryChangeService
    {
        private readonly ITransactionRepository _transactions;
        private readonly IBudgetRepository _budgets;

        public CategoryChangeService(ITransactionRepository transactions, IBudgetRepository budgets)
        {
            _transactions = transactions;
            _budgets = budgets;
        }

        public List<CategoryChangeDto> GetCategoryChanges (int year, int month)
        {
            return new List<CategoryChangeDto>();
        }
    }
}
