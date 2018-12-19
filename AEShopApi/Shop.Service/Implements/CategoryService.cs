using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Service.Implements
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public ICategoryRepository _categoryRepository;
        public IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }

        public bool CheckExistsById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteAsync(Category category)
        {
            _categoryRepository.Delete(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _categoryRepository.GetAllAsync();
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _categoryRepository.GetByIdAsync(id);
        }

        public async Task InsertAsync(Category category)
        {
            await _categoryRepository.InsertAsync(category);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            _categoryRepository.Update(category);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}