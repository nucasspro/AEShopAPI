using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Admin : Entity, IAggregateRoot
    {
        public Admin()
        {
            Products = new HashSet<Product>();
            Categories = new HashSet<Category>();
            Discounts = new HashSet<Discount>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string AdminImage { get; set; }
        public bool Gender { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Discount> Discounts { get; set; }
    }
}