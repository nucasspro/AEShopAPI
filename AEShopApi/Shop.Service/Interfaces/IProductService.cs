using Shop.Domain.Entities;
using System.Threading.Tasks;

namespace Shop.Service
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetByName(string name);
    }
}