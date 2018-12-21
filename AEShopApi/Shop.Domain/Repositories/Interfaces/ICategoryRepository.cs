using Shop.Domain.Entities;
using Shop.Domain.SeedWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Domain.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        bool CheckExistsById(int id);
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<IEnumerable<CategoryStatusType>> GetCategoryStatusTypes();
        Task<bool> Delete(int id);
    }
}