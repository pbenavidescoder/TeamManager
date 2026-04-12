using Microsoft.Data.Sqlite;

namespace TeamManagerAPI.Infrastructure
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString;
        public DbConnectionFactory(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("SQLiteConnection")!;
        }

        public SqliteConnection CreateConnection() => new SqliteConnection(_connectionString);
    }
}
