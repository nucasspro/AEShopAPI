using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Description).IsRequired(false).HasColumnName("Description").HasColumnType("nvarchar(200)");
            builder.Property(x => x.Image).IsRequired(false).HasColumnName("Image").HasColumnType("varchar(100)");

            builder.Property(x => x.ParentId).IsRequired(false).HasColumnName("ParentId").HasColumnType("int");
            builder.HasOne(x => x.Parent).WithMany().HasForeignKey(z => z.ParentId);

            builder.Property(x => x.DiscountId).IsRequired(false).HasColumnName("DiscountId").HasColumnType("int");
            builder.HasOne(x => x.Discount).WithMany(y => y.Categories).HasForeignKey(z => z.DiscountId);
                        
        }
    }
}