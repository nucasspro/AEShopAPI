using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain.EntitiesConfiguration
{
   public class PostCategoryConfiguration : BaseConfiguration<PostCategory>
    {
        public override void Configure(EntityTypeBuilder<PostCategory> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name ).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(250)");
            builder.Property(x => x.MetaTitle ).IsRequired(false).HasColumnName("MetaTitle").HasColumnType("nvarchar(250)");

            builder.Property(x => x.ParentId ).IsRequired(false).HasColumnName("ParentId").HasColumnType("int");
            builder.HasOne(x => x.Parent).WithMany().HasForeignKey(y => y.ParentId);

            builder.Property(x => x.DisplayOrder ).IsRequired(false).HasColumnName("DisplayOrder").HasColumnType("int");
            builder.Property(x => x.SeoTitle ).IsRequired(false).HasColumnName("SeoTitle").HasColumnType("nvarchar(250)");
            builder.Property(x => x.MetaKeywords ).IsRequired(false).HasColumnName("MetaKeywords").HasColumnType("nvarchar(250)");
            builder.Property(x => x.MetaDescriptions ).IsRequired(false).HasColumnName("MetaDescriptions").HasColumnType("nvarchar(250)");
            builder.Property(x => x.Status ).IsRequired(false).HasColumnName("Status").HasColumnType("bit");
            builder.Property(x => x.ShowOnHome ).IsRequired(false).HasColumnName("ShowOnHome").HasColumnType("bit");
        }
    }
}
