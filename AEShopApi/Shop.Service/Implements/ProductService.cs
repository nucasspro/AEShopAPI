using Shop.Domain.Entities;
using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Service.Implements
{
    public class ProductService : IProductService
    {
        #region Variables

        private readonly IUnitOfWork _unitOfWork;

        #endregion Variables

        #region Constructor

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion Constructor

        #region Implements

        public IEnumerable<Product> GetAll()
        {
            return _unitOfWork._productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _unitOfWork._productRepository.GetById(id);
        }

        public void Insert(Product product)
        {
            _unitOfWork._productRepository.Insert(product);
            _unitOfWork.SaveChanges();
        }

        public void Update(Product product)
        {
            _unitOfWork._productRepository.Update(product);
            _unitOfWork.SaveChanges();
        }

        public void Delete(Product product)
        {
            _unitOfWork._productRepository.Delete(product);
            _unitOfWork.SaveChanges();
        }

        public bool CheckExistsById(int id)
        {
            return _unitOfWork._productRepository.CheckExistsById(id);
        }

        #endregion Implements
    }
}