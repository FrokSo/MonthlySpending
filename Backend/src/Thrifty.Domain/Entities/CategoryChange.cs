using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Domain.Enums;

namespace Thrifty.Domain.Entities
{
    internal class CategoryChange
    {
        public CategoryId Category { get; set; }
        public int PercentChange { get; set;}
    }
}
