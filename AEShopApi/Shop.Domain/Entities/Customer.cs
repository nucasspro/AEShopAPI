using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Customer : Entity, IAggregateRoot
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserImage { get; set; }
        public bool Gender { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}