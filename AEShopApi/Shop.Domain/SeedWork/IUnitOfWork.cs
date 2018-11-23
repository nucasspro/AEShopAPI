using Shop.Domain.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace Shop.Domain.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> GetRepository<T>() where T : Entity;

        void SaveChanges();
        Task SaveChangesAsync();
    }
}