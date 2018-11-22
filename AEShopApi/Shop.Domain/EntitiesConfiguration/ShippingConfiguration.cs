using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class ShippingConfiguration : BaseConfiguration<Shipping>
    {
        public override void Configure(EntityTypeBuilder<Shipping> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.ShippingCode).IsRequired(false).HasColumnName("ShippingCode").HasColumnType("varchar(20)");
            builder.Property(x => x.ShippingPrice).IsRequired(false).HasColumnName("ShippingPrice").HasColumnType("float");
            builder.Property(x => x.ShippingStatus).IsRequired(false).HasColumnName("ShippingStatus").HasColumnType("nvarchar(50)");

            builder.Property(x => x.ProviderId).IsRequired(false).HasColumnName("ProviderId").HasColumnType("int");
            builder.HasOne(x => x.Provider).WithMany(y => y.Shippings).HasForeignKey(z => z.ProviderId);
        }
    }
}