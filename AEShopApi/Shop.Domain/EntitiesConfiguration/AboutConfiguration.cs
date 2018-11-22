using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.EntitiesConfiguration
{
   public class AboutConfiguration : BaseConfiguration<About>
    {
        public override void Configure(EntityTypeBuilder<About> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Title).IsRequired(false).HasColumnName("Title").HasColumnType("nvarchar(50)");
            builder.Property(x => x.MetaData).IsRequired(false).HasColumnName("MetaData").HasColumnType("nvarchar(250)");
            builder.Property(x => x.Description).IsRequired(false).HasColumnName("Description").HasColumnType("nvarchar(250)");
            builder.Property(x => x.Image).IsRequired(false).HasColumnName("Image").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Detail).IsRequired(false).HasColumnName("Detail").HasColumnType("text");
            builder.Property(x => x.MetaKeywords).IsRequired(false).HasColumnName("MetaKeywords").HasColumnType("nvarchar(250)");
            builder.Property(x => x.MetaDescriptions).IsRequired(false).HasColumnName("MetaDescriptions").HasColumnType("nvarchar(250)");
            builder.Property(x => x.Status).IsRequired(false).HasColumnName("Status").HasColumnType("bit");
        }
    }
}
