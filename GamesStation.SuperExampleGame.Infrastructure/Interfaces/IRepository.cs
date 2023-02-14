using GamesStation.SuperExampleGame.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GamesStation.SuperExampleGame.Infrastructure.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(long id);
        Task<int> Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task SaveChanges();
    }
}