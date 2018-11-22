using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Payment : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}