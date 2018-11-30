using System;
using System.Collections.Generic;

namespace Shop.ViewModel.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        public CategoryViewModel()
        {
            ProductViewModels = new HashSet<ProductViewModel>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? ParentId { get; set; }
        public CategoryViewModel Parent { get; set; }
        public int? DiscountId { get; set; }
        public DiscountViewModel Discount { get; set; }
        //public int CreatedBy { get; set; }
        //public int UpdatedBy { get; set; }
        //public Admin Admin { get; set; }
        public ICollection<ProductViewModel> ProductViewModels { get; set; }
    }
}