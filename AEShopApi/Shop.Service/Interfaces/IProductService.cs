using Shop.Domain.Entities;
using System.Collections.Generic;

namespace Shop.Service.Implements
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void Insert(Product product);

        void Update(Product product);

        void Delete(Product product);

        bool CheckExistsById(int id);
    }
}