using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModel.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            OrderDetailViewModels = new HashSet<OrderDetailViewModel>();
        }

        public string OrderCode { get; set; }
        public float? SubTotal { get; set; }
        public float GrandTotal { get; set; }
        public int CustomerId { get; set; }
        public CustomerViewModel Customer { get; set; }
        public string Status { get; set; }
        public bool IsVerify { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public int ShippingId { get; set; }
        public ShippingViewModel Shipping { get; set; }
        public float? PackageWidth { get; set; }
        public float? PackageHeight { get; set; }
        public float? PackageLength { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentViewModel Payment { get; set; }

        public ICollection<OrderDetailViewModel> OrderDetailViewModels { get; set; }
    }
}
