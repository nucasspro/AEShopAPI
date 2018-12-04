using Shop.Domain.Entities;
using Shop.Service.Implements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
   public interface IAboutService : IService<About>
    {
        Task<IEnumerable<About>> GetAllAsync();

        Task<About> GetByIdAsync(int id);

        Task InsertAsync(About product);

        Task UpdateAsync(About product);

        Task DeleteAsync(About product);

        Task DeleteAsync(int id);

        bool CheckExistsById(int id);
    }
}
