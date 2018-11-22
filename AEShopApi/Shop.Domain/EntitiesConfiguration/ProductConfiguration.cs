using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Sku).IsRequired(false).HasColumnName("Sku").HasColumnType("varchar(20)");
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(100)");
            builder.Property(x => x.Quantity).IsRequired(false).HasColumnName("Quantity").HasColumnType("int");
            builder.HasOne(x => x.ProductStatusType).WithMany(y => y.Products).HasForeignKey(z => z.ProductStatusId);

            builder.Property(x => x.Description).IsRequired(false).HasColumnName("Description").HasColumnType("nvarchar(250)");
            builder.Property(x => x.Detail).IsRequired(false).HasColumnName("Detail").HasColumnType("text");
            builder.Property(x => x.Weight).IsRequired(false).HasColumnName("Weight").HasColumnType("float");
            builder.Property(x => x.Width).IsRequired(false).HasColumnName("Width").HasColumnType("float");
            builder.Property(x => x.Height).IsRequired(false).HasColumnName("Height").HasColumnType("float");
            builder.Property(x => x.Length).IsRequired(false).HasColumnName("Length").HasColumnType("float");
            builder.Property(x => x.PromotionPrice).IsRequired(false).HasColumnName("PromotionPrice").HasColumnType("float");
            builder.Property(x => x.RegularPrice).IsRequired(false).HasColumnName("RegularPrice").HasColumnType("float");

            builder.Property(x => x.ProductCategoryId).IsRequired(false).HasColumnName("CategoryId").HasColumnType("int");

            builder.Property(x => x.Image1).IsRequired(false).HasColumnName("Image1").HasColumnType("varchar(100)");
            builder.Property(x => x.Image2).IsRequired(false).HasColumnName("Image2").HasColumnType("varchar(100)");
            builder.Property(x => x.Image3).IsRequired(false).HasColumnName("Image3").HasColumnType("varchar(100)");
            builder.Property(x => x.Image4).IsRequired(false).HasColumnName("Image4").HasColumnType("varchar(100)");

            builder.Property(x => x.DiscountId).IsRequired(false).HasColumnName("DiscountId").HasColumnType("int");
            builder.HasOne(x => x.Discount).WithMany(y => y.Products).HasForeignKey(z => z.DiscountId);
        }
    }
}