using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Repositories.Implements
{
    public class ProvinceRepository : Repository<Province>, IProvinceRepository
    {
        public ProvinceRepository(AeDbContext context) : base(context)
        {
        }
    }
}
