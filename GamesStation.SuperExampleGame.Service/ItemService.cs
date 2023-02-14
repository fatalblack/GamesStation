using GamesStation.SuperExampleGame.Dto.ItemDtos;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using GamesStation.SuperExampleGame.Service.Interfaces;
using System.Collections.Generic;
using System.Linq;
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
            var result = await this._repository.GetAll();
            return result.Select(r => new ItemResponseDto(r)).ToList();
        }
    }
}