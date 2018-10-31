using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
            builder.HasOne(x => x.Product).WithMany(y => y.ProductCategories).HasForeignKey(z => z.ProductId);
            builder.HasOne(x => x.Category).WithMany(y => y.ProductCategories).HasForeignKey(z => z.CategoryId);
            builder.Property(x => x.ProductId).IsRequired(true).HasColumnName("ProductId").HasColumnType("int");
            builder.Property(x => x.CategoryId).IsRequired(true).HasColumnName("CategoryId").HasColumnType("int");
            builder.Property(x => x.InsertedAt).IsRequired().HasColumnName("InsertedAt").HasColumnType("int");
            builder.Property(x => x.UpdatedAt).IsRequired().HasColumnName("UpdatedAt").HasColumnType("int");
        }
    }
}