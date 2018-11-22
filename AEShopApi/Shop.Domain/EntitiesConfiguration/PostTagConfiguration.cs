using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.EntitiesConfiguration
{
   public class PostTagConfiguration : BaseConfiguration<PostTag>
    {
        public override void Configure(EntityTypeBuilder<PostTag> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.PostId).IsRequired(false).HasColumnName("PostId").HasColumnType("int");
            builder.HasOne(x => x.Post).WithMany(y => y.PostTag).HasForeignKey(z => z.PostId);

            builder.Property(x => x.TagId).IsRequired(false).HasColumnName("TagId").HasColumnType("int");
            builder.HasOne(x => x.Tag).WithMany(y => y.PostTags).HasForeignKey(z => z.TagId);
    }
    }
}
