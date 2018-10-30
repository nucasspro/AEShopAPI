using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public interface ICategoryService
    {
        Task<Category> GetByName(string name);
        Task<Category> GetMore(int id, string name);

    }
}
