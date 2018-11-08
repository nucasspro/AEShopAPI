using Shop.Domain.Entities;
using Shop.Domain.SeedWork;

namespace Shop.Domain.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        bool CheckExistsById(int id);
    }
}