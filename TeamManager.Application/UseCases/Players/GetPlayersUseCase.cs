using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager.Domain.Entities;
using TeamManager.Domain.Interfaces;

namespace TeamManager.Application.UseCases.Players
{
    public class GetPlayersUseCase
    {
        private readonly IPlayerRepository _playerRepository;

        public GetPlayersUseCase(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<List<Player>> ExecuteAsync()
        {
            return await _playerRepository.GetAllAsync();
        }
    }
}
