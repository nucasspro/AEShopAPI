using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class Shipping : Entity, IAggregateRoot
    {
        public string ShippingCode { get; set; }
        public float ShippingPrice { get; set; }
        public string ShippingStatus { get; set; }
        public int ProviderId { get; set; }
        public ShippingProvider Provider { get; set; }
        public Order Order { get; set; }
    }
}