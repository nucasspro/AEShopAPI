using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Username").HasColumnType("varchar(20)");
            builder.Property(x => x.Password).IsRequired(false).HasColumnName("Password").HasColumnType("varchar(100)");
            builder.Property(x => x.FirstName).IsRequired(false).HasColumnName("FirstName").HasColumnType("nvarchar(50)");
            builder.Property(x => x.LastName).IsRequired(false).HasColumnName("LastName").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Address).IsRequired(false).HasColumnName("Address").HasColumnType("nvarchar(100)");
            builder.Property(x => x.Phone).IsRequired(false).HasColumnName("Phone").HasColumnType("varchar(15)");
            builder.Property(x => x.Email).IsRequired(false).HasColumnName("Name").HasColumnType("varchar(50)");
            builder.Property(x => x.Status).IsRequired(false).HasColumnName("Status").HasColumnType("bit");

        }
    }
}