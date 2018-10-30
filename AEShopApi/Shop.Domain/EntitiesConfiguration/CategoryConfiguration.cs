using Shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Shop.Domain.EntitiesConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int");
            builder.Property(x => x.Name).IsRequired(true).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(x => x.ParentId).IsRequired(false).HasColumnName("ParentId").HasColumnType("int");
            builder.Property(x => x.InsertedAt).IsRequired(true).HasColumnName("InsertedAt").HasColumnType("int");
            builder.Property(x => x.UpdatedAt).IsRequired(true).HasColumnName("UpdatedAt").HasColumnType("int");
        }
    }
}
