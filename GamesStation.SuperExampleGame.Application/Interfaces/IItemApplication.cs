using GamesStation.SuperExampleGame.Dto.ItemDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Application.Interfaces
{
    /// <summary>
    /// Item Application
    /// </summary>
    public interface IItemApplication
    {
        /// <summary>
        /// Get all Items
        /// </summary>
        /// <returns>Collection of Item</returns>
        Task<List<ItemResponseDto>> GetAll();
    }
}