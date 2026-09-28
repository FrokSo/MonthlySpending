using System.Text.Json;
using System.Text.Json.Serialization;
using Thrifty.Application;
using Thrifty.Infrastructure;

namespace Thrifty.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            var connectionString = builder.Configuration.GetConnectionString("Default")
                ?? throw new InvalidOperationException("Connection string 'Default' is missing.");

            builder.Services.AddApplication();
            builder.Services.AddInfrastructure(connectionString, builder.Environment.ContentRootPath);

            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    // Enums serialize as the frontend's string unions, e.g. "food", "on-track".
                    options.JsonSerializerOptions.Converters.Add(
                        new JsonStringEnumConverter(JsonNamingPolicy.KebabCaseLower));
                });
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.Services.MigrateDatabase();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
