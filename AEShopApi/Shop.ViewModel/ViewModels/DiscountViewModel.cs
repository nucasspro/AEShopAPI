using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModel.ViewModels
{
    public class DiscountViewModel : BaseViewModel
    {
        public DiscountViewModel()
        {
            ProductViewModels = new HashSet<ProductViewModel>();
            CategoryViewModels = new HashSet<CategoryViewModel>();
        }

        public string Name { get; set; }
        public string DisplayName { get; set; }
        public float DiscountValue { get; set; }
        public float MaximumDiscount { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartedTime { get; set; }
        public DateTime ExpriredTime { get; set; }
        public string CouponCode { get; set; }
        public bool IsRedeem { get; set; }
        //public int CreatedBy { get; set; }
        //public int UpdatedBy { get; set; }
        //public Admin Admin { get; set; }

        public ICollection<ProductViewModel> ProductViewModels { get; set; }
        public ICollection<CategoryViewModel> CategoryViewModels { get; set; }
    }
}
