using System.Collections.Generic;

namespace Shop.Domain.SeedWork
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        #region Variables

        public readonly AeDbContext _context;

        #endregion Variables

        #region Constructor

        public Repository(AeDbContext context)
        {
            _context = context;
        }

        #endregion Constructor

        #region Implements

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T Insert(T entity)
        {
            return _context.Set<T>().Add(entity).Entity;
        }

        public T Delete(T entity)
        {
            return _context.Set<T>().Remove(entity).Entity;
        }

        public void Delete(int id)
        {
            var result = GetById(id);
            _context.Set<T>().Remove(result);
        }

        public T Update(T entity)
        {
            return _context.Set<T>().Update(entity).Entity;
        }

        #endregion Implements
    }
}