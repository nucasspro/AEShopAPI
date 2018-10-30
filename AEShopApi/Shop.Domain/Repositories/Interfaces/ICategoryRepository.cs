using Shop.Domain.Entities;
using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Repositories.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetByName(string name);
        Task<Category> GetMore(int id, string name);

    }
}
