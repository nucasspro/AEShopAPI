using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        public IProductRepository ProductRepository;

        public ProductService(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        public override void Insert(Product product)
        {
            product.Sku = "SKU001";
            ProductRepository.Insert(product);
        }

        public async Task<Product> GetByName(string name)
        {
            return await ProductRepository.GetProductsByName(name);
        }
    }
}