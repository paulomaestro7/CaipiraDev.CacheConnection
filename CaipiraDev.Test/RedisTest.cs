using CaipiraDev.CacheConnection.Controller.Interface;
using NUnit.Framework;
using System;

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

        private void CacheSettings()
        {
            _iCacheConnection.ConnectionString = "";
            _iCacheConnection.ConnectionStringPort = 6380;
            _iCacheConnection.User = "";
            _iCacheConnection.Password = "";
        }
    }
}