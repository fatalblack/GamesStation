using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Infrastructure
{
    public class ItemRepository : IItemRepository
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<Item> _entities;

        public ItemRepository(ApplicationContext context)
        {
            this._context = context;
            this._entities = context.Set<Item>();
        }

        public async Task<List<Item>> GetAll()
        {
            return await this._entities
                .Include(e => e.ItemType)
                .Include(e => e.PriceList)
                .ThenInclude(se => se.CurrencyType)
                .Include(e => e.SkillList)
                .ThenInclude(se => se.SkillType)
                .Include(e => e.SkillList)
                .ThenInclude(se => se.LevelType)
                .ToListAsync();
        }
    }
}