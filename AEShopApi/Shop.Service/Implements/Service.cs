using Shop.Domain.SeedWork;

namespace Shop.Service
{
    public class Service<T> : IService<T> where T : Entity
    {
        public Repository<T> Repository;

        public virtual void Insert(T entity)
        {
            Repository.Insert(entity);
        }

        public virtual void Update(T entity)
        {
            Repository.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            Repository.Delete(entity);
        }
    }
}