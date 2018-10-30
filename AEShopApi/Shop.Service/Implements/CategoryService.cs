using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class CategoryService : ICategoryService
    {
        public ICategoryRepository CategoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            CategoryRepository = categoryRepository;
        }

        public async Task<Category> GetByName(string name)
        {
            return await CategoryRepository.GetByName(name);
        }

        public async Task<Category> GetMore(int id, string name)
        {
            return await CategoryRepository.GetMore(id, name);
        }
    }
}