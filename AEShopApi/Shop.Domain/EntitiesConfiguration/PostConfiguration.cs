using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class PostConfiguration : BaseConfiguration<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Title).IsRequired(false).HasColumnName("Title").HasColumnType("nvarchar(250)");
            builder.Property(x => x.MetaTitle).IsRequired(false).HasColumnName("MetaTitle").HasColumnType("nvarchar(250)");
            builder.Property(x => x.Description).IsRequired(false).HasColumnName("Description").HasColumnType("nvarchar(250)");
            builder.Property(x => x.NewImage).IsRequired(false).HasColumnName("NewImage").HasColumnType("nvarchar(250)");

            builder.Property(x => x.PostCategoryId).IsRequired(false).HasColumnName("PostCategoryId").HasColumnType("int");
            builder.HasOne(x => x.PostCategory).WithMany(y => y.Posts).HasForeignKey(z => z.PostCategoryId);

            builder.Property(x => x.Detail).IsRequired(false).HasColumnName("Detail").HasColumnType("text");
            builder.Property(x => x.MetaKeywords).IsRequired(false).HasColumnName("MetaKeywords").HasColumnType("nvarchar(250)");
            builder.Property(x => x.MetaDescriptions).IsRequired(false).HasColumnName("MetaDescriptions").HasColumnType("nvarchar(250)");
            builder.Property(x => x.Status).IsRequired(false).HasColumnName("Status").HasColumnType("bit");
            builder.Property(x => x.ViewCount).IsRequired(false).HasColumnName("ViewCount").HasColumnType("int");
            builder.Property(x => x.TagId).IsRequired(false).HasColumnName("TagId").HasColumnType("int");
        }
    }
}