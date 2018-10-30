using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.SeedWork
{
    public interface IUnitOfWork : IDisposable
    {

        //IRepository<T> GetRepository<T>() where T : Entity;

        Task SaveChange();
    }
}
