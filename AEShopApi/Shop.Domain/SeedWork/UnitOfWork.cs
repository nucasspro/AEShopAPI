using Shop.Domain.Repositories.Implements;
using Shop.Domain.Repositories.Interfaces;

namespace Shop.Domain.SeedWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables

        private readonly AeDbContext _context;
        public IProductRepository _productRepository { get; private set; }

        #endregion Variables

        #region Constructor

        public UnitOfWork(AeDbContext context)
        {
            _context = context;
            _productRepository = new ProductRepository(_context);
        }

        #endregion Constructor

        #region Implements

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion Implements
    }
}