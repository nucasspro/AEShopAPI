using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Common.Commons;
using Shop.Domain.Entities;
using System;

namespace Shop.Domain.EntitiesConfiguration
{
    public class ProductStatusTypeConfiguration : BaseConfiguration<ProductStatusType>
    {
        public override void Configure(EntityTypeBuilder<ProductStatusType> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.HasData(
                new ProductStatusType { Id = 1, Name = "Out of stock", InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new ProductStatusType { Id = 2, Name = "Stock", InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) }
            );
        }
    }
}