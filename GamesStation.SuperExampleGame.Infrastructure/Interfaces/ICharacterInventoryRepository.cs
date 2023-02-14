using GamesStation.SuperExampleGame.Domain.Entities;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Infrastructure.Interfaces
{
    public interface ICharacterInventoryRepository
    {
        Task<int> Insert(CharacterInventory entity);
    }
}