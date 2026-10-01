using System;
using System.Collections.Generic;
using System.Text;

namespace Thrifty.Domain.Entities
{
    public class MonthlySpend
    {
        public DateTime Month { get; set; }
        public int Amount { get; set; }
    }
}
