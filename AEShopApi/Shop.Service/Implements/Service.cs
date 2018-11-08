using Shop.Domain.SeedWork;
using Shop.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Shop.Service.Implements
{
    public class Service<T> : IService<T> where T : Entity
    {

        #region Variables

        private readonly IUnitOfWork _unitOfWork;

        #endregion Variables



        /// <summary>
        /// NEED FIX THIS ERROR
        /// Add generation function to get entity repository to run base CRUD
        /// </summary>
        /// <returns></returns>


        public IEnumerable<T> GetAll()
        {
            return null;
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T product)
        {
            throw new NotImplementedException();
        }

        public void Update(T product)
        {
            throw new NotImplementedException();
        }

        public void Delete(T product)
        {
            throw new NotImplementedException();
        }

        public bool CheckExistsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}