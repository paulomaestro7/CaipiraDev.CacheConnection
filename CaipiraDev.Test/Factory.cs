using CaipiraDev.CacheConnection.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CaipiraDev.Test
{
    internal class Factory
    {
        public Factory(ref IServiceProvider service)
        {
            var services = new ServiceCollection();
            services.CacheConnection();
            service = services.BuildServiceProvider();
        }
    }
}