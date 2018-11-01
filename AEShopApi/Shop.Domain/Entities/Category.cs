using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Category : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? ParentId { get; set; }
        public Category Parent { get; set; }
        public int? DiscountId { get; set; }
        public Discount Discount { get; set; }
        //public int CreatedBy { get; set; }
        //public int UpdatedBy { get; set; }
        public Admin Admin { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}