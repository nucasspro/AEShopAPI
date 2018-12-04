using Shop.Domain.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace Shop.Domain.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
        Task SaveChangesAsync();
    }
}