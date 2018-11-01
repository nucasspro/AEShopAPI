using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.SeedWork;

namespace Shop.Domain.EntitiesConfiguration
{
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("int");
            builder.Property(x => x.InsertedAt).IsRequired(true).HasColumnName("InsertedAt").HasColumnType("int");
            builder.Property(x => x.UpdatedAt).IsRequired(true).HasColumnName("UpdatedAt").HasColumnType("int");
        }
    }
}