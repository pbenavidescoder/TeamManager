using System.Data;

namespace TeamManagerAPI.Infrastructure
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString;
        private readonly Func<IDbConnection> _connectionCreator;
        public DbConnectionFactory(string connectionString, Func<IDbConnection> creator)
        {
            _connectionString = connectionString;
            _connectionCreator = creator;
        }

        public IDbConnection CreateConnection() => _connectionCreator();
    }
}
