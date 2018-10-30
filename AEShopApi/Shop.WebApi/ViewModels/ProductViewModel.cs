using System.Collections.Generic;

namespace Shop.WebApi.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            ProductCategories = new HashSet<ProductCategoryViewModel>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int RegularPrice { get; set; }
        public int DiscountPrice { get; set; }
        public int Quantity { get; set; }

        public ICollection<ProductCategoryViewModel> ProductCategories { get; set; }
    }
}