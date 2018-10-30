using System;

namespace Shop.WebApi.ViewModels
{
    public class ProductCategoryViewModel
    {
        public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
        public int CategoryId { get; set; }
        public CategoryViewModel Category { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}