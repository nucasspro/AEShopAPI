using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class CategoryStatusType : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}