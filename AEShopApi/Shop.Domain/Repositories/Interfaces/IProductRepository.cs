using Shop.Domain.Entities;
using Shop.Domain.SeedWork;
using System.Threading.Tasks;

namespace Shop.Domain.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetProductsByName(string name);
    }
}