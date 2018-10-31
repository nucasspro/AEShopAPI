using System;

namespace Shop.WebApi.ViewModels
{
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public string ParentName { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}