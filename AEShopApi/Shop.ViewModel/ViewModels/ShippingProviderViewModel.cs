using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModel.ViewModels
{
    public class ShippingProviderViewModel : BaseViewModel
    {
        public ShippingProviderViewModel()
        {
            ShippingViewModels = new HashSet<ShippingViewModel>();
        }

        public string Name { get; set; }
        public ICollection<ShippingViewModel> ShippingViewModels { get; set; }
    }
}
