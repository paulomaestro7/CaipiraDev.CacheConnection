using CaipiraDev.CacheConnection.Controller;
using CaipiraDev.CacheConnection.Controller.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CaipiraDev.CacheConnection.Configuration
{
    public static class InjectionCacheConnection
    {
        public static void CacheConnection(this IServiceCollection services)
        {
            services.AddScoped<ICacheConnection, CacheConnectionController>();
        }
    }
}
