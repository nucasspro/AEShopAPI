using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class ShippingProvider : Entity, IAggregateRoot
    {
        public ShippingProvider()
        {
            Shippings = new HashSet<Shipping>();
        }

        public string Name { get; set; }
        public ICollection<Shipping> Shippings { get; set; }
    }
}