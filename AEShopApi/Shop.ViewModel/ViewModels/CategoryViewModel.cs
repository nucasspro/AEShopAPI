using System;

namespace Shop.ViewModel.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public int? CategoryStatusTypeId { get; set; }
        public virtual CategoryStatusTypeViewModel CategoryStatusType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public virtual CategoryViewModel Parent { get; set; }
        public string InsertedAt { get; set; }
        public string UpdatedAt { get; set; }
    }
}