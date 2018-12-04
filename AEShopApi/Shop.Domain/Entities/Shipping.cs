using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Shipping : Entity, IAggregateRoot
    {
        public string ShippingCode { get; set; }
        public float? ShippingPrice { get; set; }
        public string ShippingStatus { get; set; }

        public int? ProviderId { get; set; }
        public virtual ShippingProvider Provider { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}