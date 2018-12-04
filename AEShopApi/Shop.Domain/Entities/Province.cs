using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Province : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public virtual ICollection<District> Districts { get; set; }
    }
}