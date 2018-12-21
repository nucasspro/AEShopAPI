using Shop.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
    public interface IProductService : IService<Product>
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId, int pageSize, int getNumber);

        Task<IEnumerable<Product>> GetProductsWithPagination(int PageSize, int GetNumber);

        Task<Product> GetByIdAsync(int id);

        Task<Product> GetBySkuAsync(string sku);

        Task InsertAsync(Product product);

        Task UpdateAsync(Product product);

        Task DeleteAsync(Product product);

        Task DeleteAsync(int id);

        bool CheckExistsById(int id);

    }
}