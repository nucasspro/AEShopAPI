using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Discount : Entity, IAggregateRoot
    {
        public Discount()
        {
            Products = new HashSet<Product>();
            Categories = new HashSet<Category>();
        }

        public string Name { get; set; }
        public string DisplayName { get; set; }
        public float DiscountValue { get; set; }
        public float MaximumDiscount { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartedTime { get; set; }
        public DateTime ExpriredTime { get; set; }
        public string CouponCode { get; set; }
        public bool IsRedeem { get; set; }
        //public int CreatedBy { get; set; }
        //public int UpdatedBy { get; set; }
        public Admin Admin { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}