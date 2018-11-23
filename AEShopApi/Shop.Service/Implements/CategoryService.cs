using Shop.Domain.Entities;
using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using System.Collections.Generic;

namespace Shop.Service.Implements
{
    public class CategoryService : ICategoryService
    {
        #region Variables

        private readonly IUnitOfWork _unitOfWork;

        #endregion Variables

        #region Constructor

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion Constructor

        #region Implements

        public IEnumerable<Category> GetAll()
        {
            //return _unitOfWork._categoryRepository.GetAll();
            return null;
        }

        public Category GetById(int id)
        {
            //return _unitOfWork._categoryRepository.GetById(id);
            return null;

        }

        public void Insert(Category category)
        {
            //_unitOfWork._categoryRepository.Insert(category);
            _unitOfWork.SaveChanges();
        }

        public void Update(Category category)
        {
            //_unitOfWork._categoryRepository.Update(category);
            _unitOfWork.SaveChanges();
        }

        public void Delete(Category category)
        {
            //_unitOfWork._categoryRepository.Delete(category);
            _unitOfWork.SaveChanges();
        }

        public bool CheckExistsById(int id)
        {
            //return _unitOfWork._categoryRepository.CheckExistsById(id);
            return false;
        }

        #endregion Implements
    }
}