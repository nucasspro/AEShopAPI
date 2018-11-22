using Shop.Domain.Entities;
using Shop.Domain.Repositories.Interfaces;
using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Repositories.Implements
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(AeDbContext context) : base(context)
        {
        }
    }
}
