using TeamManagerAPI.Domain;
using TeamManagerAPI.Repositories;

namespace TeamManagerAPI.Services
{
    public class PlayerService
    {
        private readonly IPlayerRepository _repo;
        public PlayerService(IPlayerRepository repo) => _repo = repo;
        public IEnumerable<Player> GetPlayers() => _repo.GetAll();
        public void AddPlayer(Player player)
        {
            if (player == null)
                throw new Exception("player can't be null");
        }

    }
}
