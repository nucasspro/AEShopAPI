using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class User : Entity, IAggregateRoot
    {
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int? UserStatusTypeId { get; set; }
        public virtual UserStatusType UserStatusType { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}