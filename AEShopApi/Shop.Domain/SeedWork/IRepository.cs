using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Domain.SeedWork
{
    public interface IRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAllAsync(string[] includes = null);

        Task<T> GetByIdAsync(int id);

        Task InsertAsync(T entity);

        void Update(T entity);

        Task DeleteAsync(T entity);

        Task DeleteAsync(int id);
    }
}