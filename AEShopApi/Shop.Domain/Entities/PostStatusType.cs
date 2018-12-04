using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class PostStatusType : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}