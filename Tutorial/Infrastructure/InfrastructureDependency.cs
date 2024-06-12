using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Core;

namespace Infrastructure;
public static class InfrastructureDependency
{
    public static IServiceCollection InfrastructureServicesExtension(this IServiceCollection services, ConfigurationManager configuration)
    {
        var connectionString = configuration.GetConnectionString("Postgre");
        services.AddDbContext<BaseContext>(options => options.UseNpgsql(connectionString));

        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}