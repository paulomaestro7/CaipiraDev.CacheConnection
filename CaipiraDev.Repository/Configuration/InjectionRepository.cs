using Microsoft.Extensions.DependencyInjection;
using LiteDB;
using CaipiraDev.Repository.Interface;
using System;
using System.IO;

namespace CaipiraDev.Repository.Configuration
{
    public static class InjectionRepository
    {
        public static void Repository(this IServiceCollection service)
        {
            service.AddSingleton<ILiteDatabase>(new LiteDatabase(Path.Combine(AppContext.BaseDirectory, "dataBaseCache.db")));
            service.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}
