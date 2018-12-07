using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Repositories.Implements
{
    public class WardRepository : Repository<Ward>, IWardRepository
    {
        public WardRepository(AeDbContext context) : base(context)
        {
        }
    }
}
