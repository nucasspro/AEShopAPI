using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.EntitiesConfiguration
{
   public class WardConfiguration : BaseConfiguration<Ward>
    {
        public override void Configure(EntityTypeBuilder<Ward> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Type).IsRequired(false).HasColumnName("Type").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Location).IsRequired(false).HasColumnName("Location").HasColumnType("nvarchar(250)");
            builder.Property(x => x.DistrictId).IsRequired(false).HasColumnName("DistrictId").HasColumnType("int");
            builder.HasOne(x => x.District).WithMany(y => y.Wards).HasForeignKey(z => z.DistrictId);
        }
    }
}
