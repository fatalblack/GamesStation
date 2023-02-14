using GamesStation.SuperExampleGame.Dto.ItemDtos;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using GamesStation.SuperExampleGame.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Service
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _repository;

        public ItemService(IItemRepository repository)
        {
            this._repository = repository;
        }

        public async Task<List<ItemResponseDto>> GetAll()
        {
            //TODO: realizar funcionalidad
            return new List<ItemResponseDto>();
        }
    }
}