using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class Footer : Entity, IAggregateRoot
    {
        public string Content { get; set; }
        public bool? Status { get; set; }
    }
}