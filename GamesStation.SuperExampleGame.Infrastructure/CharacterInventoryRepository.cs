using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Infrastructure
{
    public class CharacterInventoryRepository : ICharacterInventoryRepository
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<CharacterInventory> _entities;

        public CharacterInventoryRepository(ApplicationContext context)
        {
            this._context = context;
            this._entities = context.Set<CharacterInventory>();
        }

        public async Task<int> Insert(CharacterInventory entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await this._entities.AddAsync(entity);
            await this._context.SaveChangesAsync();

            return entity.Id;
        }
    }
}