using Shop.Domain.Entities;
using Shop.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Service.Implements
{
    public interface IProductService : IService<Product>
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product> GetByIdAsync(int id);

        Task InsertAsync(Product product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product product);

        Task DeleteAsync(int id);

        bool CheckExistsById(int id);
    }
}