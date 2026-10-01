using Microsoft.Extensions.DependencyInjection;
using Thrifty.Application.Budgets;
using Thrifty.Application.CategoryChange;
using Thrifty.Application.DailySpend;
using Thrifty.Application.MonthlySpend;
using Thrifty.Application.Summary;
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
            services.AddScoped<SummaryService>();
            services.AddScoped<CategoryChangeService>();

            return services;
        }
    }
}
