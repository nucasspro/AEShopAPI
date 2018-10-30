using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.SeedWork
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
