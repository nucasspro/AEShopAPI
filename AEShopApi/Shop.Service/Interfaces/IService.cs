using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Service
{
    public interface IService<T> where T : class
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
