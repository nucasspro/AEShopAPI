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
            builder.Property(x => x.ShippingCode).IsRequired(true).HasColumnName("ShippingCode").HasColumnType("varchar(20)");
            builder.Property(x => x.ShippingPrice).IsRequired(true).HasColumnName("ShippingPrice").HasColumnType("float");
            builder.Property(x => x.ShippingStatus).IsRequired(true).HasColumnName("ShippingStatus").HasColumnType("nvarchar(50)");

            builder.Property(x => x.ProviderId).IsRequired(true).HasColumnName("ProviderId").HasColumnType("int");
            builder.HasOne(x => x.Provider).WithMany(y => y.Shippings).HasForeignKey(z => z.ProviderId);
        }
    }
}