using Shop.Domain.SeedWork;
using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Product : Entity, IAggregateRoot
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public string MetaTitle { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public string MoreImages { get; set; }
        public float? PromotionPrice { get; set; }
        public float? RegularPrice { get; set; }
        public bool? IncludeVAT { get; set; }
        public int? Quantity { get; set; }
        public float? Weight { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public float? Length { get; set; }
        public int? ProductCategoryId { get; set; }
        public virtual IEnumerable<ProductCategory> ProductCategory { get; set; }
        public string Detail { get; set; }
        public string Warranty { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescriptions { get; set; }
        public bool? Status { get; set; }
        public int? ViewCounts { get; set; }
        public int? ProductStatusId { get; set; }
        public virtual ProductStatusType ProductStatusType { get; set; }
        public virtual IEnumerable<ProductCategory> ProductCategories { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public int? DiscountId { get; set; }
        public virtual Discount Discount { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}