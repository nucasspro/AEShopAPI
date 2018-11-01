using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class OrderConfiguration : BaseConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.OrderCode).IsRequired(true).HasColumnName("OrderCode").HasColumnType("varchar(20)");
            builder.Property(x => x.SubTotal).IsRequired(false).HasColumnName("SubTotal").HasColumnType("float");
            builder.Property(x => x.GrandTotal).IsRequired(true).HasColumnName("GrandTotal").HasColumnType("float");

            builder.Property(x => x.CustomerId).IsRequired(true).HasColumnName("CustomerId").HasColumnType("int");
            builder.HasOne(x => x.Customer).WithMany(y => y.Orders).HasForeignKey(z => z.CustomerId);

            builder.Property(x => x.Status).IsRequired(true).HasColumnName("Status").HasColumnType("nvarchar(50)");
            builder.Property(x => x.IsVerify).IsRequired(true).HasColumnName("IsVerify").HasColumnType("bit");
            builder.Property(x => x.ShippingAddress).IsRequired(true).HasColumnName("ShippingAddress").HasColumnType("nvarchar(100)");
            builder.Property(x => x.BillingAddress).IsRequired(true).HasColumnName("BillingAddress").HasColumnType("nvarchar(100)");

            builder.Property(x => x.ShippingId).IsRequired(true).HasColumnName("ShippingId").HasColumnType("int");
            builder.HasOne(x => x.Shipping).WithOne(y => y.Order).HasForeignKey<Order>(z => z.ShippingId);

            builder.Property(x => x.PackageWidth).IsRequired(false).HasColumnName("PackageWidth").HasColumnType("float");
            builder.Property(x => x.PackageHeight).IsRequired(false).HasColumnName("PackageHeight").HasColumnType("float");
            builder.Property(x => x.PackageLength).IsRequired(false).HasColumnName("PackageLength").HasColumnType("float");

            builder.Property(x => x.PaymentMethodId).IsRequired(true).HasColumnName("PaymentMethodId").HasColumnType("int");
            builder.HasOne(x => x.Payment).WithMany(y => y.Orders).HasForeignKey(z => z.PaymentMethodId);
        }
    }
}