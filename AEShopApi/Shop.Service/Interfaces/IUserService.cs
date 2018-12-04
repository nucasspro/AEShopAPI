using Shop.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
    public interface IUserService : IService<User>
    {
        Task<IEnumerable<User>> GetAllAsync();

        Task<User> GetByIdAsync(int id);

        Task InsertAsync(User product);

        Task UpdateAsync(User product);

        Task DeleteAsync(User product);

        Task DeleteAsync(int id);

        bool CheckExistsById(int id);
        User Authenticate(string username, string password);
        bool AddNew(User user, string password);
    }
}
