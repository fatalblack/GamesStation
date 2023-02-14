using GamesStation.SuperExampleGame.Domain.Results;
using GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Service.Interfaces
{
    /// <summary>
    /// Character Inventory Service
    /// </summary>
    public interface ICharacterInventoryService
    {
        /// <summary>
        /// Insert a Character Inventory
        /// </summary>
        /// <param name="request">Character Inventory to insert</param>
        /// <returns>Inserted Id</returns>
        Task<GenericResult<int?>> Add(CharacterInventoryAddRequestDto request);
    }
}