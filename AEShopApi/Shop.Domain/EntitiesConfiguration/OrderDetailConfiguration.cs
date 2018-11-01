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
            builder.Property(x => x.OrderId).IsRequired(true).HasColumnName("OrderId").HasColumnType("int");
            builder.HasOne(x => x.Order).WithMany(y => y.OrderDetails).HasForeignKey(z => z.OrderId);

            builder.Property(x => x.ProductId).IsRequired(true).HasColumnName("ProductId").HasColumnType("int");
            builder.HasOne(x => x.Product).WithMany(y => y.OrderDetails).HasForeignKey(z => z.ProductId);

            builder.Property(x => x.Quantity).IsRequired(true).HasColumnName("Quantity").HasColumnType("int");
        }
    }
}