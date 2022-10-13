using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ILS.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddLoggerApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}