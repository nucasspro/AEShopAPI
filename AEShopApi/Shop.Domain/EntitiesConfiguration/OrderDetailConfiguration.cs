using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class OrderDetailConfiguration : BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.OrderId).IsRequired(false).HasColumnName("OrderId").HasColumnType("int");
            builder.HasOne(x => x.Order).WithMany(y => y.OrderDetails).HasForeignKey(z => z.OrderId);

            builder.Property(x => x.ProductId).IsRequired(false).HasColumnName("ProductId").HasColumnType("int");
            builder.HasOne(x => x.Product).WithMany(y => y.OrderDetails).HasForeignKey(z => z.ProductId);

            builder.Property(x => x.UserId).IsRequired(false).HasColumnName("UserId").HasColumnType("int");
            builder.HasOne(x => x.User).WithMany(y => y.OrderDetails).HasForeignKey(z => z.UserId);

            builder.Property(x => x.ShippingId).IsRequired(false).HasColumnName("ShippingId").HasColumnType("int");
            builder.HasOne(x => x.Shipping).WithMany(y => y.OrderDetails).HasForeignKey(z => z.ShippingId);

            builder.Property(x => x.Quantity).IsRequired(false).HasColumnName("Quantity").HasColumnType("int");
        }
    }
}