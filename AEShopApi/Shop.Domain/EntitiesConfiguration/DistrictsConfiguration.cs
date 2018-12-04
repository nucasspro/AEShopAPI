using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class DistrictsConfiguration : BaseConfiguration<District>
    {
        public override void Configure(EntityTypeBuilder<District> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Type).IsRequired(false).HasColumnName("Type").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Location).IsRequired(false).HasColumnName("Location").HasColumnType("nvarchar(250)");
            builder.Property(x => x.ProvinceId).IsRequired(false).HasColumnName("ProvinceId").HasColumnType("int");
            builder.HasOne(x => x.Province).WithMany(y => y.Districts).HasForeignKey(z => z.ProvinceId);
        }
    }
}