﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class OrderConfiguration : BaseConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.OrderCode).IsRequired(false).HasColumnName("OrderCode").HasColumnType("varchar(20)");
            builder.Property(x => x.SubTotal).IsRequired(false).HasColumnName("SubTotal").HasColumnType("float");
            builder.Property(x => x.GrandTotal).IsRequired(false).HasColumnName("GrandTotal").HasColumnType("float");

            builder.Property(x => x.UserId).IsRequired(true).HasColumnName("UserId").HasColumnType("int");
            builder.HasOne(x => x.User).WithMany(y => y.Orders).HasForeignKey(z => z.UserId);

            builder.Property(x => x.Status).IsRequired(false).HasColumnName("Status").HasColumnType("nvarchar(50)");
            builder.Property(x => x.IsVerify).IsRequired(false).HasColumnName("IsVerify").HasColumnType("bit");
            builder.Property(x => x.ShippingAddress).IsRequired(false).HasColumnName("ShippingAddress").HasColumnType("nvarchar(100)");
            builder.Property(x => x.BillingAddress).IsRequired(false).HasColumnName("BillingAddress").HasColumnType("nvarchar(100)");

            builder.Property(x => x.ShippingId).IsRequired(false).HasColumnName("ShippingId").HasColumnType("int");
            builder.HasOne(x => x.Shipping).WithOne(y => y.Order).HasForeignKey<Order>(z => z.ShippingId);

            builder.Property(x => x.PackageWidth).IsRequired(false).HasColumnName("PackageWidth").HasColumnType("float");
            builder.Property(x => x.PackageHeight).IsRequired(false).HasColumnName("PackageHeight").HasColumnType("float");
            builder.Property(x => x.PackageLength).IsRequired(false).HasColumnName("PackageLength").HasColumnType("float");

            builder.Property(x => x.PaymentMethodId).IsRequired(false).HasColumnName("PaymentMethodId").HasColumnType("int");
            builder.HasOne(x => x.Payment).WithMany(y => y.Orders).HasForeignKey(z => z.PaymentMethodId);
        }
    }
}