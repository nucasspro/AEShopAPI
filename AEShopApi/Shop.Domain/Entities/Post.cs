using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Post : Entity, IAggregateRoot
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }

        public int? PostStatusTypeId { get; set; }
        public PostStatusType PostStatusType { get; set; }

        public int? ViewCount { get; set; }
    }
}