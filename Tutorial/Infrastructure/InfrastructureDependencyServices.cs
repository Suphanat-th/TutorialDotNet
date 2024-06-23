using Core;
using Domain;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;
public static class InfrastructureDependencyServices
{
    public static IServiceCollection InfrastructureServicesExtension(this IServiceCollection services, ConfigurationManager configuration)
    {
        // //  SQLITE
        // services.AddDbContext<DataContext>(options => options.UseSqlite(configuration.GetConnectionString("Sqlite")));
        //ProsgretSQL
        services.AddDbContext<DataContext>(options => options.UseNpgsql(configuration.GetConnectionString("Postgres")));

        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}