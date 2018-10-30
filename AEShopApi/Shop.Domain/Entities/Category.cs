using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Category : Entity, IAggregateRoot
    {
        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int InsertedAt { get; set; }
        public int UpdatedAt { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}