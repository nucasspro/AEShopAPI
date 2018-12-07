using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Ward : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public int? DistrictId { get; set; }
        public virtual District District { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}