using Shop.Domain.Entities;
using System.Collections.Generic;

namespace Shop.Service.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();

        Category GetById(int id);

        void Insert(Category product);

        void Update(Category product);

        void Delete(Category product);

        bool CheckExistsById(int id);
    }
}