using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System.Linq;

namespace Shop.Domain.Repositories.Implements
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AeDbContext context) : base(context)
        {
        }

        public bool CheckUserExists(string username)
        {
            return _context.Set<User>().Any(x => x.UserName == username);
        }
        public User GetByUsername(string username)
        {
            var user = _context.Set<User>().AsNoTracking().SingleOrDefault(x => x.UserName == username);
            if (user == null)
            {
                return null;
            }
            return user;
        }
    }
}