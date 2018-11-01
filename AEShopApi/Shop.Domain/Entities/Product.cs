using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Product : Entity, IAggregateRoot
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Name { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public float Status { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public float? Weight { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public float? Length { get; set; }
        public int? PromotionPrice { get; set; }
        public int RegularPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        //public int CreatedBy { get; set; }
        //public int UpdatedBy { get; set; }
        public Admin Admin { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}