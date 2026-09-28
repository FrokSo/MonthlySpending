using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thrifty.Domain.Entities;
using Thrifty.Infrastructure.Persistence.Seed;

namespace Thrifty.Infrastructure.Persistence.Configurations;

public class BudgetConfiguration : IEntityTypeConfiguration<Budget>
{
    public void Configure(EntityTypeBuilder<Budget> builder)
    {
        builder.ToTable("Budgets");

        builder.Property(b => b.Category).HasConversion<string>().HasMaxLength(20);
        builder.Property(b => b.Limit).HasConversion<MoneyConverter>();

        // One budget per category per month.
        builder.HasIndex(b => new { b.Category, b.Year, b.Month }).IsUnique();

        builder.HasData(SeedData.Budgets);
    }
}
