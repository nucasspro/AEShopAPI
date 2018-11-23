using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Service.Implements
{
    public class Service<T> : IService<T> where T : Entity
    {
        #region Variables

        private readonly IUnitOfWork _unitOfWork;

        #endregion Variables

        #region Constructor

        public Service(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #endregion Constructor

        #region Methods

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _unitOfWork.GetRepository<T>().GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _unitOfWork.GetRepository<T>().GetByIdAsync(id);
        }

        public async Task InsertAsync(T product)
        {
            await _unitOfWork.GetRepository<T>().InsertAsync(product);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(T product)
        {
            _unitOfWork.GetRepository<T>().Update(product);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(T product)
        {
            await _unitOfWork.GetRepository<T>().DeleteAsync(product);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.GetRepository<T>().DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }

        public bool CheckExistsById(int id)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}