using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.EntitiesConfiguration
{
   public class MenuTypeConfiguration : BaseConfiguration<MenuType>
    {
        public override void Configure(EntityTypeBuilder<MenuType> builder)
        {
            base.Configure(builder);
            builder.Property(x=>x.Name).IsRequired(false).HasColumnName("MetaDescriptions").HasColumnType("nvarchar(250)");
        }
    }
}
