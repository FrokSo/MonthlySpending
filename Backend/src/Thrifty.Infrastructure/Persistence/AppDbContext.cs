using Microsoft.EntityFrameworkCore;
using Thrifty.Domain.Entities;

namespace Thrifty.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Transaction> Transactions
        {
            get { return Set<Transaction>(); }
        }

        public DbSet<Budget> Budgets
        {
            get { return Set<Budget>(); }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
