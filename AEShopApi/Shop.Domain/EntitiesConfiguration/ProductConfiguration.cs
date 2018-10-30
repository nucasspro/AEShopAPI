using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Sku).IsRequired(true).HasColumnName("Sku").HasColumnType("varchar(16)");
            builder.Property(x => x.Name).IsRequired(true).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Description).IsRequired(true).HasColumnName("Description").HasColumnType("nvarchar(200)");
            builder.Property(x => x.RegularPrice).IsRequired(true).HasColumnName("RegularPrice").HasColumnType("int");
            builder.Property(x => x.DiscountPrice).IsRequired(true).HasColumnName("DiscountPrice").HasColumnType("int");
            builder.Property(x => x.Quantity).IsRequired(true).HasColumnName("Quantity").HasColumnType("int");
            builder.Property(x => x.InsertedAt).IsRequired(true).HasColumnName("InsertedAt").HasColumnType("int");
            builder.Property(x => x.UpdatedAt).IsRequired(true).HasColumnName("UpdatedAt").HasColumnType("int");
        }
    }
}