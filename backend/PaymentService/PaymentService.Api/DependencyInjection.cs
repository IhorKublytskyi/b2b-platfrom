using Microsoft.EntityFrameworkCore;
using PaymentService.Api.Persistence;

namespace PaymentService.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddPersistence(config);
        return services;
    }

    private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetConnectionString("PostgreSQL");

        return services.AddDbContext<BillingDbContext>(options =>
            options.UseNpgsql(connectionString));
    }
}
