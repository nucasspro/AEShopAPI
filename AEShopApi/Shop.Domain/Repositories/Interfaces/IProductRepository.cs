using Shop.Domain.Entities;
using Shop.Domain.SeedWork;

namespace Shop.Domain.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        bool CheckExistsById(int id);
    }
}