using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;

namespace Shop.Service.Implements
{
    public class ProductService : Service<Product>, IProductService
    {
        public IProductRepository _productRepository;
        public IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork, IProductRepository productRepository)
        {
            _unitOfWork = unitOfWork;
            _productRepository = productRepository;
        }
        
        public bool CheckExistsById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteAsync(Product product)
        {
            await _productRepository.DeleteAsync(product);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task InsertAsync(Product product)
        {
            await _productRepository.InsertAsync(product);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _productRepository.Update(product);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}