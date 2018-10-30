using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Entities
{
    public class Product : Entity, IAggregateRoot
    {
        public Product()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int Id { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RegularPrice { get; set; }
        public int? DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public int InsertedAt { get; set; }
        public int UpdatedAt { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
