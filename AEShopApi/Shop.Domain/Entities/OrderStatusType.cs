using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class OrderStatusType : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}