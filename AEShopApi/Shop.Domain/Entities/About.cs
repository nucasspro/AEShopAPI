using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class About : Entity, IAggregateRoot
    {
        public string Title { get; set; }
        public string MetaData { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Detail { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }
        public bool? Status { get; set; }
    }
}