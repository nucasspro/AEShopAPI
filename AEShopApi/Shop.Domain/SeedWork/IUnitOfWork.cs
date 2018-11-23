using Shop.Domain.Repositories.Interfaces;
using System;

namespace Shop.Domain.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        //IProductRepository _productRepository { get; }
        //ICategoryRepository _categoryRepository { get; }
        IRepository<T> GetRepository<T>() where T : Entity;

        void SaveChanges();
    }
}