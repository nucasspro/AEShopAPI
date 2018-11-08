using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebApi.ViewModels
{
    public class ProductStatusTypeViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
    }
}
