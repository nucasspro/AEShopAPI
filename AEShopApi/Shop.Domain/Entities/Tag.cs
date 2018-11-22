using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Entities
{
   public class Tag : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }   
}
