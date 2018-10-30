using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetByName(string name);
    }
}
