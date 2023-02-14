using GamesStation.SuperExampleGame.Dto.CharacterDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Service.Interfaces
{
    /// <summary>
    /// Character Service
    /// </summary>
    public interface ICharacterService
    {
        /// <summary>
        /// Get all Characters
        /// </summary>
        /// <returns>Collection of Character</returns>
        Task<List<CharacterResponseDto>> GetAll();
    }
}