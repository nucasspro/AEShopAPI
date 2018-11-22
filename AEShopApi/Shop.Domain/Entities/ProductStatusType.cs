using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class ProductStatusType : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}