using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Thrifty.Application.Abstractions;
using Thrifty.Infrastructure.Persistence;
using Thrifty.Infrastructure.Repositories;

namespace Thrifty.Infrastructure
{
    public static class DependencyInjection
    {
        // contentRootPath anchors a relative SQLite path (e.g. "thrifty.db") to the API project folder,
        // so `dotnet run`, Visual Studio and `dotnet ef` all use the same database file.
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, string connectionString, string contentRootPath)
        {
            var sqlite = new SqliteConnectionStringBuilder(connectionString);
            if (!Path.IsPathRooted(sqlite.DataSource))
            {
                sqlite.DataSource = Path.Combine(contentRootPath, sqlite.DataSource);
            }

            services.AddDbContext<AppDbContext>(options => options.UseSqlite(sqlite.ToString()));
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            return services;
        }

        // Creates the database and applies any pending migrations.
        public static void MigrateDatabase(this IServiceProvider services)
        {
            using (var scope = services.CreateScope())
            {
                scope.ServiceProvider.GetRequiredService<AppDbContext>().Database.Migrate();
            }
        }
    }
}
