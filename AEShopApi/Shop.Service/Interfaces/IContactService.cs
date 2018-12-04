using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
   public interface IContactService : IService<Contact>
    {
        Task<IEnumerable<Contact>> GetAllAsync();

        Task<Contact> GetByIdAsync(int id);

        Task InsertAsync(Contact product);

        Task UpdateAsync(Contact product);

        Task DeleteAsync(Contact product);

        Task DeleteAsync(int id);

        bool CheckExistsById(int id);
    }
}
