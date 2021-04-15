using CaipiraDev.CacheConnection.Controller.Interface;
using CaipiraDev.Model;
using CaipiraDev.Repository;
using CaipiraDev.Repository.Interface;
using NUnit.Framework;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using LiteDB;

namespace CaipiraDev.Test
{
    public class RepositoryTest
    {
        private IServiceProvider _iService;
        private IBaseRepository<ConnectionModel> _iBaseRepository;

        [SetUp]
        public void Setup()
        {
            new Factory(ref _iService);
            _iBaseRepository = (IBaseRepository<ConnectionModel>)_iService.GetService(typeof(IBaseRepository<ConnectionModel>));
        }

        [Test]
        public void Connection_Test_Ok()
        {
           var result = _iBaseRepository.InsertOne(new ConnectionModel()
            {
                Name = "Azure Redis",
                Address = "",
                Port = 6380,
                Password = ""
            });

            Assert.IsTrue(true);
        }

    }
}