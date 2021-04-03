using CaipiraDev.CacheConnection.Controller.Interface;
using StackExchange.Redis;

namespace CaipiraDev.CacheConnection.Controller
{
    public class CacheConnectionController : ICacheConnection
    {
        public ConnectionMultiplexer Connection { get; private set; }

        public string ConnectionString { private get; set; }
        public int ConnectionStringPort { private get; set; }
        public string User { private get; set; }
        public string Password { private get; set; }
        
        public void CacheConnection()
        {
            Connection = ConnectionMultiplexer.Connect(new ConfigurationOptions()
            {
                User = User,
                Password = Password,
                EndPoints = { { ConnectionString, ConnectionStringPort } }
            });
        }
    }
}
