using TeamManager.Domain.Entities;

namespace TeamManager.Domain.Interfaces
{

public interface IPlayerRepository
     {
        Task<Player?> GetByIdAsync(int id);
        Task<List<Player>> GetAllAsync();
        Task AddAsync(Player player);
        Task UpdateAsync(Player player);
        Task DeleteAsync(int id);
    }
}
