using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.EntitiesConfiguration
{
    public class FeedbackConfiguration : BaseConfiguration<Feedback>
    {
        public override void Configure(EntityTypeBuilder<Feedback> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Phone).IsRequired(false).HasColumnName("Phone").HasColumnType("varchar(15)");
            builder.Property(x => x.Email).IsRequired(false).HasColumnName("Email").HasColumnType("varchar(50)");
            builder.Property(x => x.Address).IsRequired(false).HasColumnName("Address").HasColumnType("nvarchar(100)");
            builder.Property(x => x.Content).IsRequired(false).HasColumnName("Content").HasColumnType("text");
            builder.Property(x => x.Status).IsRequired(false).HasColumnName("Status").HasColumnType("bit");
        }
    }
}
