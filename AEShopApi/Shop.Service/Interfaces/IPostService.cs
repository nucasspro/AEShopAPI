using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
   public interface IPostService : IService<Post>
    {
        Task<IEnumerable<Post>> GetAllAsync();

        Task<Post> GetByIdAsync(int id);

        Task InsertAsync(Post product);

        Task UpdateAsync(Post product);

        Task DeleteAsync(Post product);

        Task DeleteAsync(int id);

        bool CheckExistsById(int id);
    }
}
