using Microsoft.Extensions.DependencyInjection;
using Thrifty.Application.Budget;
using Thrifty.Application.Category;
using Thrifty.Application.Transactions;

namespace Thrifty.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<TransactionService>();
            services.AddScoped<BudgetServices>();
            services.AddScoped<CategoryServices>();

            return services;
        }
    }
}
