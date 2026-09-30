using Microsoft.Extensions.DependencyInjection;
using Thrifty.Application.Budgets;
using Thrifty.Application.DailySpend;
using Thrifty.Application.MonthlySpend;
using Thrifty.Application.Transactions;

namespace Thrifty.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<TransactionService>();
            services.AddScoped<BudgetServices>();
            services.AddScoped<DailySpendServices>();
            services.AddScoped<MonthlySpendServices>();

            return services;
        }
    }
}
