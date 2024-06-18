using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Core;
public static class CoreDependencyServices
{

    public static IServiceCollection CoreServicesExtension(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddTransient<IServicesUser, ServicesUser>();
        return services;
    }
}