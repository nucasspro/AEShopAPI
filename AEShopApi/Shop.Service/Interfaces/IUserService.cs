using Shop.Domain.Entities;

namespace Shop.Service.Interfaces
{
    public interface IUserService : IService<User>
    {
        User Authenticate(string username, string password);
        bool AddNew(User user, string password);
    }
}
