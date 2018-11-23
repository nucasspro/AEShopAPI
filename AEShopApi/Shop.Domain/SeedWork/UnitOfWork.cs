using Shop.Domain.Repositories.Interfaces;
using System;
using System.Collections;

namespace Shop.Domain.SeedWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables

        private readonly AeDbContext _context;
        //public IProductRepository _productRepository { get; private set; }
        //public ICategoryRepository _categoryRepository { get; private set; }
        private Hashtable repositories = new Hashtable();

        #endregion Variables

        #region Constructor



        public UnitOfWork(AeDbContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : Entity
        {
            if (!repositories.Contains(typeof(T)))
            {
                repositories.Add(typeof(T), new Repository<T>(_context));
            }
            return (IRepository<T>)repositories[typeof(T)];
        }


        //public UnitOfWork(
        //    AeDbContext context,
        //    IProductRepository productRepository,
        //    ICategoryRepository categoryRepository)
        //{
        //    _context = context;
        //    _productRepository = productRepository;
        //    _categoryRepository = categoryRepository;
        //}

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