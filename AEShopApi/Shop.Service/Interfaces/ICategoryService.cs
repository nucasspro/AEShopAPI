using Shop.Domain.Entities;
using System.Threading.Tasks;

namespace Shop.Service
{
    public interface ICategoryService
    {
        Task<Category> GetByName(string name);

        Task<Category> GetMore(int id, string name);
    }
}