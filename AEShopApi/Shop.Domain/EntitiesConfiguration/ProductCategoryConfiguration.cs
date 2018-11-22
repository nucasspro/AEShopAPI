using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class ProductCategoryConfiguration : BaseConfiguration<ProductCategory>
    {
         
        public override void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.ProductId).IsRequired(false).HasColumnName("ProductId").HasColumnType("int");
            builder.HasOne(x => x.Product).WithMany(y => y.ProductCategories).HasForeignKey(z => z.ProductId);
            builder.Property(x => x.CategoryId).IsRequired(false).HasColumnName("CategoryId").HasColumnType("int");
            builder.HasOne(x => x.Category).WithMany(y => y.ProductCategories).HasForeignKey(z => z.CategoryId);

        }
    }
}