using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class OrderDetail : Entity, IAggregateRoot
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}