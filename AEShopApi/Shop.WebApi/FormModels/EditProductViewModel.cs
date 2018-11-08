using Shop.WebApi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebApi.FormModels
{
    public class EditProductViewModel
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public int ProductStatusId { get; set; }
        //public virtual ProductStatusTypeViewModel ProductStatusType { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public float? Weight { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public float? Length { get; set; }
        public int? PromotionPrice { get; set; }
        public int RegularPrice { get; set; }
        public int CategoryId { get; set; }
        //public CategoryViewModel Category { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public int? DiscountId { get; set; }
        //public DiscountViewModel Discount { get; set; }

        //public int CreatedBy { get; set; }
        //public int UpdatedBy { get; set; }
        //public Admin Admin { get; set; }
        //public ICollection<OrderDetailViewModel> OrderDetailViewModels { get; set; }
    }
}
