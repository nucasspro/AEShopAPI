﻿using Shop.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.Entities
{
    public class ProductCategory : Entity, IAggregateRoot
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int InsertedAt { get; set; }
        public int UpdatedAt { get; set; }
    }
}