using Shop.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
    public interface ICategoryService : IService<Category>
    {
        Task<IEnumerable<Category>> GetAllAsync();

        Task<Category> GetByIdAsync(int id);

        Task InsertAsync(Category product);

        Task UpdateAsync(Category product);

        Task DeleteAsync(Category product);

        Task DeleteAsync(int id);

        bool CheckExistsById(int id);
    }
}