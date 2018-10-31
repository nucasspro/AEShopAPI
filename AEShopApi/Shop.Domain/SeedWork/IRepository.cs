using System.Collections.Generic;

namespace Shop.Domain.SeedWork
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll(string[] includes = null);

        T GetById(int id);

        T Insert(T entity);

        T Update(T entity);

        T Delete(T entity);

        void Delete(int id);


    }
}