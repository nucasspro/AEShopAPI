using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class OrderDetail : Entity, IAggregateRoot
    {
        public int? OrderId { get; set; }
        public virtual Order Order { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int ShippingId { get; set; }
        public virtual Shipping Shipping { get; set; }

        public int? Quantity { get; set; }
    }
}