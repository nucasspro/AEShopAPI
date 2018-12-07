using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebReact.Services.Interfaces
{
   public interface IHomeService
    {
        Task<IEnumerable<Product>> GetProducts(int number);
    }
}
