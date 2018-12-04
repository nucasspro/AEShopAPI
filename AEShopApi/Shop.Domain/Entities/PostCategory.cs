using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class PostCategory : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string MetaTitle { get; set; }

        public int? ParentId { get; set; }
        public virtual PostCategory Parent { get; set; }

        public int? DisplayOrder { get; set; }
        public string SeoTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }
        public bool? Status { get; set; }
        public bool? ShowOnHome { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}