using Shop.Domain.Entities;
using System.Threading.Tasks;

namespace Shop.Domain.SeedWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private AeDbContext _dbContext = new AeDbContext();
        private Repository<Product> productRepository;
        //private Repository<Category> categoryRepository;

        public Repository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new Repository<Product>(DbContext);
                }
                return productRepository;
            }
        }

        public AeDbContext DbContext
        {
            get => _dbContext;
            set => _dbContext = value;
        }

        public async Task SaveChange()
        {
            await DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            DbContext?.Dispose();
        }
    }
}