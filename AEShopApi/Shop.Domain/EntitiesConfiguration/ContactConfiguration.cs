using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.EntitiesConfiguration
{
   public class ContactConfiguration : BaseConfiguration<Contact>
    {
        public override void Configure(EntityTypeBuilder<Contact> builder)
        {
            base.Configure(builder);
            builder.Property(x=>x.Content).IsRequired(false).HasColumnName("Content").HasColumnType("text");
            builder.Property(x => x.Status).IsRequired(false).HasColumnName("Status").HasColumnType("bit");
        }
    }
}
