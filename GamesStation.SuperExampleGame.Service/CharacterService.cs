using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Dto.CharacterDtos;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using GamesStation.SuperExampleGame.Service.Interfaces;
using System.Collections.Generic;
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
            //TODO: realizar funcionalidad
            return new List<CharacterResponseDto>();
        }
    }
}