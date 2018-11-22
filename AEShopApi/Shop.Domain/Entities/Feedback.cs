﻿using Shop.Domain.SeedWork;

namespace Shop.Domain.Entities
{
    public class Feedback : Entity, IAggregateRoot
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Content { get; set; }
        public bool? Status { get; set; }
    }
}