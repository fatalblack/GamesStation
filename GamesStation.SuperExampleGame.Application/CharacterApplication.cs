using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Dto.CharacterDtos;
using GamesStation.SuperExampleGame.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Application
{
    public class CharacterApplication : ICharacterApplication
    {
        private readonly ICharacterService _characterService;

        public CharacterApplication(ICharacterService characterService)
        {
            this._characterService = characterService;
        }

        public async Task<List<CharacterResponseDto>> GetAll()
        {
            return await this._characterService.GetAll();
        }
    }
}