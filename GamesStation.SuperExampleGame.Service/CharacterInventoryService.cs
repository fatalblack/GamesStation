using GamesStation.SuperExampleGame.Domain.Results;
using GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using GamesStation.SuperExampleGame.Service.Interfaces;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Service
{
    public class CharacterInventoryService : ICharacterInventoryService
    {
        private readonly ICharacterInventoryRepository _repository;

        public CharacterInventoryService(ICharacterInventoryRepository repository)
        {
            this._repository = repository;
        }

        public async Task<GenericResult<int?>> Add(CharacterInventoryAddRequestDto request)
        {
            //TODO: realizar funcionalidad
            return GenericResult<int?>.SetOk(1);
        }
    }
}