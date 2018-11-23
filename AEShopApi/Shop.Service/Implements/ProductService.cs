using Shop.Domain.Entities;
using Shop.Domain.SeedWork;

namespace Shop.Service.Implements
{
    public class ProductService : Service<Product>, IProductService
    {
        #region Constructor

        public ProductService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        #endregion Constructor
    }
}