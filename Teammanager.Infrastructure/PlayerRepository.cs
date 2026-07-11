using TeamManager.Domain.Entities;
using TeamManager.Domain.Interfaces;
using Dapper;
using System.Data;


namespace TeamManagerAPI.Infrastructure
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DbConnectionFactory _dbConnectionFactory;

        public PlayerRepository(DbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }
        public async Task<List<Player>> GetAllAsync()
        {
            using var connection = _dbConnectionFactory.CreateConnection();
            var sql = "SELECT * from Players";
            var result = await connection.QueryAsync<Player>(sql);
            return result.ToList();
        }

        public Task<Player?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Player player)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Player player)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
