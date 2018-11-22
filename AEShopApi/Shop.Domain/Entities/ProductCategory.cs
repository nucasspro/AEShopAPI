﻿using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class ProductCategory : Entity, IAggregateRoot
    {
        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}