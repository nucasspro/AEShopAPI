using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class ProductStatusType : Entity, IAggregateRoot
    {
        public ProductStatusType()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}