using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System.Linq;

namespace Shop.Domain.Repositories.Implements
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AeDbContext context) : base(context)
        {
        }

        #region Implements

        public bool CheckExistsById(int id)
        {
            return _context.Set<Product>().Any(x => x.Id == id);
        }

        #endregion Implements
    }
}