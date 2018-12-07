using System;

namespace Shop.ViewModel.ViewModels
{
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual CategoryViewModel Parent { get; set; }
        public DateTime CreatedAt{ get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}