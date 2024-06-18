using Core;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;
public static class InfrastructureDependencyServices
{
    public static IServiceCollection InfrastructureServicesExtension(this IServiceCollection services, ConfigurationManager configuration)
    {
        var connectionString = configuration.GetConnectionString("Sqlite");
        services.AddDbContext<DataContext>(options => options.UseSqlite(connectionString));

        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}