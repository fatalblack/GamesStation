using GamesStation.SuperExampleGame.Domain.Results;
using GamesStation.SuperExampleGame.Dto.CharacterInventoryDtos;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Application.Interfaces
{
    /// <summary>
    /// Store Application
    /// </summary>
    public interface IStoreApplication
    {
        /// <summary>
        /// Buy an Item
        /// </summary>
        /// <param name="request">Request</param>
        /// <returns>Inserted Id</returns>
        Task<GenericResult<int?>> Buy(CharacterInventoryAddRequestDto request);
    }
}