using Shop.Domain.Commons;
using Shop.Domain.Entities;

namespace Shop.WebApi.ViewModels.ModelExtensions
{
    public static class ModelExtension
    {
        public static void UpdateProductStatusType(this ProductStatusType productStatusType, ProductStatusTypeViewModel productStatusTypeViewModel)
        {
            productStatusType.Id = productStatusTypeViewModel.Id;
            productStatusType.Name = productStatusTypeViewModel.Name;
            productStatusType.InsertedAt = ConvertDatetime.ConvertToTimeSpan(productStatusTypeViewModel.InsertedAt);
            productStatusType.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(productStatusTypeViewModel.UpdatedAt);
        }


        public static void UpdateProduct(this Product product, ProductViewModel productViewModel)
        {
            product.Name = productViewModel.Name;
            product.Sku = productViewModel.Sku;
            product.Quantity = productViewModel.Quantity;

            //public int ProductStatusId { get; set; }

            //public virtual ProductStatusTypeViewModel ProductStatusType { get; set; }
            product.Description = productViewModel.Description;
            product.Detail = productViewModel.Detail;
            product.Weight = productViewModel.Weight;
            product.Width = productViewModel.Width;
            product.Height = productViewModel.Height;
            product.Length = productViewModel.Length;
            product.PromotionPrice = productViewModel.PromotionPrice;
            product.RegularPrice = productViewModel.RegularPrice;
            product.CategoryId = productViewModel.CategoryId;
            product.Image1 = productViewModel.Image1;
            product.Image2 = productViewModel.Image2;
            product.Image3 = productViewModel.Image3;
            product.Image4 = productViewModel.Image4;
            product.DiscountId = productViewModel.DiscountId;
            product.InsertedAt = ConvertDatetime.ConvertToTimeSpan(productViewModel.InsertedAt);
            product.UpdatedAt = ConvertDatetime.ConvertToTimeSpan(productViewModel.UpdatedAt);
        }
    }
}