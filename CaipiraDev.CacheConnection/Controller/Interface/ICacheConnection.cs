using StackExchange.Redis;

namespace CaipiraDev.CacheConnection.Controller.Interface
{
    public interface ICacheConnection
    {
        public string ConnectionString { set; }
        public int ConnectionStringPort { set; }
        public string User { set; }
        public string Password { set; }
        public ConnectionMultiplexer Connection { get; }
        void CacheConnection();
    }
}
