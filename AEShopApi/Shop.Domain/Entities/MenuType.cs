using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class MenuType : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}