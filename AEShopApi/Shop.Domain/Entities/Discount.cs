using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Discount : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public float? DiscountValue { get; set; }
        public float? MaximumDiscount { get; set; }
        public bool? IsActive { get; set; }
        public int? StartedTime { get; set; }
        public int? ExpriredTime { get; set; }
        public string CouponCode { get; set; }
        public bool? IsRedeem { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}