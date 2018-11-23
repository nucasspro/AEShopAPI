using Shop.Domain.SeedWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
    public interface IService<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task InsertAsync(T product);

        Task UpdateAsync(T product);

        Task DeleteAsync(T product);

        Task DeleteAsync(int id);

        bool CheckExistsById(int id);
    }
}