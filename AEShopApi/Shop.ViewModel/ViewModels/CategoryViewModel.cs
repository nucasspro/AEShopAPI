using System.Collections.Generic;

namespace Shop.ViewModel.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        //public int CategoryStatusTypeId { get; set; } 
        public virtual CategoryStatusTypeViewModel CategoryStatusType { get; set; }

        //public ICollection<ProductCategoryViewModel> Products { get; set; }
    }
}