using NUnit.Framework;
using System;

namespace CaipiraDev.Test
{
    public class RedisTest
    {
        private IServiceProvider _iService;
        [SetUp]
        public void Setup()
        {
            new Factory(ref _iService);

        }

        [Test]
        public void Test1()
        {

            Assert.Pass();
        }
    }
}