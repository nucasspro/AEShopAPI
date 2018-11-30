using System.Collections.Generic;

namespace Shop.ViewModel.ViewModels
{
    public class PaymentViewModel : BaseViewModel
    {
        public PaymentViewModel()
        {
            OrderViewModels = new HashSet<OrderViewModel>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<OrderViewModel> OrderViewModels { get; set; }
    }
}