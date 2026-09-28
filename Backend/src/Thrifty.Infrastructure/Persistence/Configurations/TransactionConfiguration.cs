using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thrifty.Domain.Entities;
using Thrifty.Infrastructure.Persistence.Seed;

namespace Thrifty.Infrastructure.Persistence.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transactions");

            builder.Property(t => t.Merchant).HasMaxLength(200).IsRequired();
            builder.Property(t => t.Note).HasMaxLength(500);
            builder.Property(t => t.PaymentMethod).HasMaxLength(50).IsRequired();
            builder.Property(t => t.Category).HasConversion<string>().HasMaxLength(20);
            builder.Property(t => t.Amount).HasConversion<MoneyConverter>();

            builder.HasIndex(t => t.Date);

            builder.HasData(SeedData.Transactions);
        }
    }
}
