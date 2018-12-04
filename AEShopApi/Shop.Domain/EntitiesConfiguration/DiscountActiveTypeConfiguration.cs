using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class DiscountActiveTypeConfiguration : BaseConfiguration<DiscountActiveType>
    {
        public override void Configure(EntityTypeBuilder<DiscountActiveType> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(50)");
        }
    }
}