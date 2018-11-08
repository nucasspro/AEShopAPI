using Shop.Domain.Repositories.Interfaces;
using System;

namespace Shop.Domain.SeedWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables

        private readonly AeDbContext _context;
        public IProductRepository _productRepository { get; private set; }
        public ICategoryRepository _categoryRepository { get; private set; }

        #endregion Variables

        #region Constructor

        public UnitOfWork(
            AeDbContext context,
            IProductRepository productRepository,
            ICategoryRepository categoryRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
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