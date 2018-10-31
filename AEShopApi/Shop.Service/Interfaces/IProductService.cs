using Shop.Domain.Entities;

namespace Shop.Service.Implements
{
    public interface IProductService
    {
        Product GetById(int id);

        void Insert(Product product);

        void Update(Product product);

        void Delete(Product product);

        bool CheckExistsById(int id);
    }
}