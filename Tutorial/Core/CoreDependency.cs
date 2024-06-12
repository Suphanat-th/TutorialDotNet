using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Core;
public static class CoreDependency
{
    public static IServiceCollection CoreServicesExtension(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddTransient<IUserServices, UserServices>();
        return services;
    }
}
