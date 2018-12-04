using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Discount : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public float? DiscountValue { get; set; }
        public float? MaximumDiscount { get; set; }
        public int? StartedTime { get; set; }
        public int? ExpriredTime { get; set; }
        public string CouponCode { get; set; }

        public int? DiscountActiveTypeId { get; set; }
        public virtual DiscountActiveType DiscountActiveType{ get; set; }

        public int? DiscountRedeemTypeId { get; set; }
        public virtual DiscountRedeemType DiscountRedeemType { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}