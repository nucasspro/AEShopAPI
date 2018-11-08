using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebApi.ViewModels
{
    public class OrderDetailViewModel : BaseViewModel
    {
        //public int OrderId { get; set; }
        public OrderViewModel Order { get; set; }
        //public int ProductId { get; set; }
        public ProductViewModel Product { get; set; }
        public int Quantity { get; set; }
    }
}
