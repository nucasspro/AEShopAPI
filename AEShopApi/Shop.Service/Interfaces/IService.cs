using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Service.Interfaces
{
    public interface IService<T> where T : Entity
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Insert(T product);

        void Update(T product);

        void Delete(T product);

        bool CheckExistsById(int id);
    }
}