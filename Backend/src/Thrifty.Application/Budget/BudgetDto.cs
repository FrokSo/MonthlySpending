using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Domain.Enums;

namespace Thrifty.Application.Budget
{
    public class BudgetDto
    {
        public int Id { get; set; }

        public CategoryId Category { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public decimal Limit { get; set; }
    }
}
