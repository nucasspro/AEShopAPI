using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class District : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public int ProvinceId { get; set; }
        public virtual Province Province { get; set; }

        public virtual ICollection<Ward> Wards { get; set; }
    }
}