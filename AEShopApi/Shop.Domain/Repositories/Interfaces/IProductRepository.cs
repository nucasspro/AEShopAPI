using Shop.Domain.Entities;
using Shop.Domain.SeedWork;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Domain.Repositories.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        bool CheckExistsById(int id);
        Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId, int pageSize, int getNumber);
        Task<IEnumerable<Product>> GetProductAsync();

        Task<IEnumerable<Product>> GetProductsWithPaginationAsync(int PageSize, int GetNumber);
        Task<Product> GetBySkuAsync(string sku);
        Task<bool> Delete(int id);
    }


}