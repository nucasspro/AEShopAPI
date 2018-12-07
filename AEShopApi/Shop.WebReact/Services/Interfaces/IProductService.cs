using Shop.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.WebReact.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts(int PageSize, int GetNumber);

        Task<IEnumerable<Product>> GetProductsByCategory(int CategoryId, int PageSize, int GetNumber);

        Task<IEnumerable<Category>> GetCategories();
    }
}