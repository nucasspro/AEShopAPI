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

            builder.Property(x => x.CategoryStatusTypeId).IsRequired(true).HasColumnName("CategoryStatusTypeId").HasColumnType("int");
            builder.HasOne(x => x.CategoryStatusType).WithMany(y => y.Categories).HasForeignKey(z => z.CategoryStatusTypeId);
        }
    }
}