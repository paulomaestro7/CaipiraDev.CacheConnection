using CaipiraDev.CacheConnection.Configuration;
using CaipiraDev.Model;
using CaipiraDev.Repository;
using CaipiraDev.Repository.Configuration;
using CaipiraDev.Repository.Interface;
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
            services.Repository();
            service = services.BuildServiceProvider();
        }
    }
}