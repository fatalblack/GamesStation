using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Domain.Results;
using GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos;
using GamesStation.SuperExampleGame.Service.Interfaces;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Application
{
    public class StoreApplication : IStoreApplication
    {
        private readonly ICharacterInventoryService _characterInventoryService;

        public StoreApplication(ICharacterInventoryService characterInventoryService)
        {
            this._characterInventoryService = characterInventoryService;
        }

        public async Task<GenericResult<int?>> Buy(CharacterInventoryAddRequestDto request)
        {
            //TODO: validar que el character exista
            //TODO: validar que el item exista
            //TODO: validar si tiene recursos para comprar
            //TODO: validar los grados

            var result = await this._characterInventoryService.Add(request);

            //TODO: restar recursos por la compra

            return result;
        }
    }
}