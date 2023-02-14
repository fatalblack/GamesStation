using GamesStation.SuperExampleGame.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Infrastructure.Interfaces
{
    public interface IItemRepository
    {
        Task<List<Item>> GetAll();
    }
}