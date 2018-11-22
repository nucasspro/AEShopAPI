using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Post : Entity, IAggregateRoot
    {
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Description { get; set; }
        public string NewImage { get; set; }

        public int? PostCategoryId { get; set; }
        public virtual PostCategory PostCategory { get; set; }

        public string Detail { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }
        public bool? Status { get; set; }
        public int? ViewCount { get; set; }
        public int? TagId { get; set; }
        public virtual IEnumerable<PostTag> PostTag { get; set; }
    }
}