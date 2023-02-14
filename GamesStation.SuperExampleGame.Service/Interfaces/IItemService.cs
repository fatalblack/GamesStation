using GamesStation.SuperExampleGame.Dto.ItemDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Service.Interfaces
{
    /// <summary>
    /// Item Service
    /// </summary>
    public interface IItemService
    {
        /// <summary>
        /// Get all Items
        /// </summary>
        /// <returns>Collection of Item</returns>
        Task<List<ItemResponseDto>> GetAll();
    }
}