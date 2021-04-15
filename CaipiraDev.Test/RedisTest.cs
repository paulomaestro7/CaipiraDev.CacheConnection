using CaipiraDev.CacheConnection.Controller.Interface;
using NUnit.Framework;
using System;
using System.Linq;

namespace CaipiraDev.Test
{
    public class RedisTest
    {
        private IServiceProvider _iService;
        private ICacheConnection _iCacheConnection;

        [SetUp]
        public void Setup()
        {
            new Factory(ref _iService);
            _iCacheConnection = (ICacheConnection)_iService.GetService(typeof(ICacheConnection));
        }

        [Test]
        public void Connection_Test_Ok()
        {
            CacheSettings();
            _iCacheConnection.CacheConnection();
            Assert.IsTrue(_iCacheConnection.Connection.IsConnected);
        }

        [Test]
        public void Connection_Test_Error()
        {
            CacheSettings();
            _iCacheConnection.Password = "error";
            _iCacheConnection.CacheConnection();
            Assert.IsTrue(!_iCacheConnection.Connection.IsConnected);
        }

        [Test]
        public void Connection_List_Ok()
        {
            CacheSettings();
            _iCacheConnection.CacheConnection();
            //var teste = _iCacheConnection.Connection.GetServer(_iCacheConnection.Connection.GetEndPoints()[0]).Keys();
            //teste.Any()
            //foreach (var key in teste)
            //{
            //    Console.WriteLine(key);
            //}
            Assert.IsTrue(_iCacheConnection.Connection.IsConnected);
        }

        private void CacheSettings()
        {
            _iCacheConnection.ConnectionString = "";
            _iCacheConnection.ConnectionStringPort = 6380;
            _iCacheConnection.User = "";
            _iCacheConnection.Password = "";
        }
    }
}