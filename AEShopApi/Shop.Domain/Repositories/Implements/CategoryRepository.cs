using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System.Linq;

namespace Shop.Domain.Repositories.Implements
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AeDbContext context) : base(context)
        {
        }

        #region Implements

        public bool CheckExistsById(int id)
        {
            return _context.Set<Category>().Any(x => x.Id == id);
        }

        #endregion Implements
    }
}