using GamesStation.SuperExampleGame.Domain.Entities;
using GamesStation.SuperExampleGame.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<T> _entities;
        string errorMessage = string.Empty;

        public Repository(ApplicationContext context)
        {
            this._context = context;
            this._entities = context.Set<T>();
        }
        public async Task<List<T>> GetAll()
        {
            return await this._entities.ToListAsync();
        }

        public async Task<T> Get(long id)
        {
            return await this._entities.FindAsync(id);
        }

        public async Task<int> Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            await this._entities.AddAsync(entity);
            await this._context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<bool> Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            var affectedRows = await this._context.SaveChangesAsync();

            return affectedRows > 0;
        }

        public async Task<bool> Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            this._entities.Remove(entity);
            var affectedRows = await this._context.SaveChangesAsync();

            return affectedRows > 0;
        }

        public async Task SaveChanges()
        {
            await this._context.SaveChangesAsync();
        }
    }
}