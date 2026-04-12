using TeamManagerAPI.Domain;

namespace TeamManagerAPI.Repositories
{

public interface IPlayerRepository
     {
        IEnumerable<Player> GetAll();
        Player GetById(int id);
        void Add(Player player);
        void Update(Player player);
        void Delete(int id);
    }
}
