using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Entities
{
  public  class DiscountRedeemType : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public virtual ICollection<Discount> Discounts{ get; set; }
    }
}
