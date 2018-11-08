using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebApi.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        public CustomerViewModel()
        {
            OrderViewModels = new HashSet<OrderViewModel>();
        }

        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string UserImage { get; set; }
        public bool Gender { get; set; }
        public bool IsActive { get; set; }

        public ICollection<OrderViewModel> OrderViewModels { get; set; }
    }
}
