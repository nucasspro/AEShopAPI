using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
namespace Shop.Domain.Repositories.Implements
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(AeDbContext context) : base(context)
        {
        }
    }
}
