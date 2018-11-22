using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.EntitiesConfiguration
{
   public class TagConfiguration : BaseConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(100)");
        }
    }
}
