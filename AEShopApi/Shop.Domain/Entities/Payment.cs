using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Payment : Entity, IAggregateRoot
    {
        public Payment()
        {
            Orders = new HashSet<Order>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}