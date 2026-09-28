using Microsoft.Extensions.DependencyInjection;
using Thrifty.Application.Transactions;

namespace Thrifty.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<TransactionService>();
            return services;
        }
    }
}
