using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class DiscountsConfiguration : BaseConfiguration<Discount>
    {
        public override void Configure(EntityTypeBuilder<Discount> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(true).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(x => x.DisplayName).IsRequired(true).HasColumnName("DisplayName").HasColumnType("nvarchar(50)");
            builder.Property(x => x.DiscountValue).IsRequired(true).HasColumnName("DiscountValue").HasColumnType("float");
            builder.Property(x => x.MaximumDiscount).IsRequired(true).HasColumnName("MaximumDiscount").HasColumnType("float");
            builder.Property(x => x.IsActive).IsRequired(true).HasColumnName("IsActive").HasColumnType("bit");
            builder.Property(x => x.StartedTime).IsRequired(true).HasColumnName("StartedTime").HasColumnType("datetime");
            builder.Property(x => x.ExpriredTime).IsRequired(true).HasColumnName("ExpriredTime").HasColumnType("datetime");
            builder.Property(x => x.CouponCode).IsRequired(true).HasColumnName("CouponCode").HasColumnType("varchar(15)");
            builder.Property(x => x.IsRedeem).IsRequired(true).HasColumnName("IsRedeem").HasColumnType("bit");

            //builder.Property(x => x.CreatedBy).IsRequired(true).HasColumnName("CreatedBy").HasColumnType("int");
            //builder.Property(x => x.UpdatedBy).IsRequired(true).HasColumnName("UpdatedBy").HasColumnType("int");
            //builder.HasOne(x => x.Admin).WithMany(y => y.Discounts).HasForeignKey(z => z.CreatedBy);
            //builder.HasOne(x => x.Admin).WithMany(y => y.Discounts).HasForeignKey(z => z.UpdatedBy);
        }
    }
}