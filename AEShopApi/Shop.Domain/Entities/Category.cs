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
        public virtual Category Parent { get; set; }
        public int? DiscountId { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    }
}