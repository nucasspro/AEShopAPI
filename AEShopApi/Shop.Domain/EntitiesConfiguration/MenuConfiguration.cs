using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.EntitiesConfiguration
{
   public class MenuConfiguration : BaseConfiguration<Menu>
    {
        public override void Configure(EntityTypeBuilder<Menu> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Text).IsRequired(false).HasColumnName("Text").HasColumnType("text");
            builder.Property(x => x.Link).IsRequired(false).HasColumnName("Link").HasColumnType("text");
            builder.Property(x => x.DisplayOrder).IsRequired(false).HasColumnName("DisplayOrder").HasColumnType("int");
            builder.Property(x => x.Target).IsRequired(false).HasColumnName("Target").HasColumnType("text");
            builder.Property(x => x.Status).IsRequired(false).HasColumnName("Status").HasColumnType("bit");
            builder.Property(x=>x.MenuTypeID).IsRequired(false).HasColumnName("MenuTypeID").HasColumnType("int");
            builder.HasOne(x => x.MenuType).WithMany(y => y.Menus).HasForeignKey(z => z.MenuTypeID);

        }
    }
}
