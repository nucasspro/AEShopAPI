using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebRedux.ViewModels
{
    public class AdminViewModel : BaseViewModel
    {
        public AdminViewModel()
        {
            ProductViewModels = new HashSet<ProductViewModel>();
            CategoryViewModels = new HashSet<CategoryViewModel>();
            DiscountViewModels = new HashSet<DiscountViewModel>();
        }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string AdminImage { get; set; }
        public string Gender { get; set; }
        public string IsActive { get; set; }

        public ICollection<ProductViewModel> ProductViewModels { get; set; }
        public ICollection<CategoryViewModel> CategoryViewModels { get; set; }
        public ICollection<DiscountViewModel> DiscountViewModels { get; set; }
    }
}
