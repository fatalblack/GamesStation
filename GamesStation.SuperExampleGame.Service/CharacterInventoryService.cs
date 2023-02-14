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
            var entity = request.AsEntity();
            var result = await this._repository.Insert(entity);

            if (result > 0)
            {
                return GenericResult<int?>.SetOk(result);
            }

            return GenericResult<int?>.SetFail("Ocurrió un error al insertar el registro en CharacterInventory");
        }
    }
}