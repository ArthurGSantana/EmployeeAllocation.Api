using EmployeeAllocation.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeAllocation.IoC;

public static class DependencyContainer
{
    public static void RegisterServices(IServiceCollection services, string? connectionString = null)
    {
        //Context
        services.AddDbContext<PostgresDbContext>(options =>
        {
            if (connectionString != null)
            {
                options.UseNpgsql(connectionString);
                options.EnableSensitiveDataLogging();
                options.EnableDetailedErrors();
            }
        });
    }

    public static void InitializeDatabase(IServiceProvider serviceProvider)
    {
        using var serviceScope = serviceProvider.CreateScope();

        var context = serviceScope.ServiceProvider.GetService<PostgresDbContext>();
        context?.Database.Migrate();
    }
}
