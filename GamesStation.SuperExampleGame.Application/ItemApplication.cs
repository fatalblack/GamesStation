using GamesStation.SuperExampleGame.Application.Interfaces;
using GamesStation.SuperExampleGame.Dto.ItemDtos;
using GamesStation.SuperExampleGame.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Application
{
    public class ItemApplication : IItemApplication
    {
        private readonly IItemService _itemService;

        public ItemApplication(IItemService itemService)
        {
            this._itemService = itemService;
        }

        public async Task<List<ItemResponseDto>> GetAll()
        {
            return await this._itemService.GetAll();
        }
    }
}