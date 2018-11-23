using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebRedux.ViewModels
{
    public class ShippingViewModel : BaseViewModel
    {
        public string ShippingCode { get; set; }
        public float ShippingPrice { get; set; }
        public string ShippingStatus { get; set; }
        public int ProviderId { get; set; }
        public ShippingProviderViewModel Provider { get; set; }
        public OrderViewModel Order { get; set; }
    }
}
