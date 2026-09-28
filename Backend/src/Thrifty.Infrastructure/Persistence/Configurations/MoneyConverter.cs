using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Thrifty.Infrastructure.Persistence.Configurations
{
    // SQLite has no decimal type and EF Core cannot SUM or ORDER BY decimals stored as TEXT,
    // so money is stored as whole cents in an INTEGER column.
    public class MoneyConverter : ValueConverter<decimal, long>
    {
        public MoneyConverter()
            : base(
                value => (long)Math.Round(value * 100m, MidpointRounding.AwayFromZero),
                cents => cents / 100m)
        {
        }
    }
}
