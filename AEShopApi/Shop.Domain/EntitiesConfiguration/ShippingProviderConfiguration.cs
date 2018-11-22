using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class ShippingProviderConfiguration : BaseConfiguration<ShippingProvider>
    {
        public override void Configure(EntityTypeBuilder<ShippingProvider> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(50)");
        }
    }
}