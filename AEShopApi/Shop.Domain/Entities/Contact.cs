using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class Contact : Entity, IAggregateRoot
    {
        public string Content { get; set; }
        public bool? Status { get; set; }
    }
}