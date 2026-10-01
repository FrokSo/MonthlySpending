using Thrifty.Domain.Enums;

namespace Thrifty.Application.CategoryChange
{
    // Percentage change in one category's spending versus the previous month.
    // Computed from transactions, so there is no entity to map from.
    public class CategoryChangeDto
    {
        public CategoryId Category { get; }

        public int PercentChange { get; }

        public CategoryChangeDto(CategoryId category, int percentChange)
        {
            Category = category;
            PercentChange = percentChange;
        }
    }
}
