using GamesStation.SuperExampleGame.Dto.CharacterDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Application.Interfaces
{
    /// <summary>
    /// Character Application
    /// </summary>
    public interface ICharacterApplication
    {
        /// <summary>
        /// Get all Characters
        /// </summary>
        /// <returns>Collection of Character</returns>
        Task<List<CharacterResponseDto>> GetAll();
    }
}