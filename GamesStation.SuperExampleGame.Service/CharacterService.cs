using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Dto.CharacterDtos;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using GamesStation.SuperExampleGame.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Service
{
    public class CharacterService : ICharacterService
    {
        private readonly IRepository<Character> _repository;

        public CharacterService(IRepository<Character> repository)
        {
            this._repository = repository;
        }

        public async Task<List<CharacterResponseDto>> GetAll()
        {
            var result = await this._repository.GetAll();
            return result.Select(r => new CharacterResponseDto(r)).ToList();
        }
    }
}