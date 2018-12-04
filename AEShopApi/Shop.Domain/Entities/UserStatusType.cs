using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class UserStatusType : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}