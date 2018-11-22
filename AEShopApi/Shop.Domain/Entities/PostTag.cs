using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class PostTag : Entity, IAggregateRoot
    {
        public int? PostId { get; set; }
        public virtual Post Post { get; set; }
        public int? TagId { get; set; }
        public virtual Tag Tag { get; set; }
    }
}