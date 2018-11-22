using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class Menu : Entity, IAggregateRoot
    {
        public string Text { get; set; }
        public string Link { get; set; }
        public int? DisplayOrder { get; set; }
        public string Target { get; set; }
        public bool? Status { get; set; }
        public int? MenuTypeID { get; set; }
        public virtual MenuType MenuType { get; set; }
    }
}