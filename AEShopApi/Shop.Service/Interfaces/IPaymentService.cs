using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
   public interface IPaymentService : IService<Payment>
    {
        Task<IEnumerable<Payment>> GetAllAsync();

        Task<Payment> GetByIdAsync(int id);

        Task InsertAsync(Payment Payment);

        Task UpdateAsync(Payment Payment);

        Task DeleteAsync(Payment Payment);

        Task DeleteAsync(int id);

        bool CheckExistsById(int id);
    }
}
