using System;
using System.Collections.Generic;
using System.Text;
using Thrifty.Domain.Enums;

namespace Thrifty.Application.Category
{
    public class CategoryDto
    {
        public CategoryId categoryId { get; set; }
        
        public string Label { get; set;  }

        public string ColorVar { get; set; }

        public string Icon { get; set; }

        public CategoryDto(CategoryId categoryIdDto, string label, string colorVar, string icon)
        {
            categoryId = categoryIdDto;
            Label = label;
            ColorVar = colorVar;
            Icon = icon;
        }






    }
}
