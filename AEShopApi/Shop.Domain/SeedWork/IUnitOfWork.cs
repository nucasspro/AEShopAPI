using Shop.Domain.Repositories.Interfaces;
using System;

namespace Shop.Domain.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository _productRepository { get; }

        void SaveChanges();
    }
}