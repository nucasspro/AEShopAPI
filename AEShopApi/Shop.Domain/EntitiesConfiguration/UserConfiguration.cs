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
            builder.Property(x => x.UserName).IsRequired(false).HasColumnName("UserName").HasColumnType("varchar(20)");
            builder.Property(x => x.PasswordHash).IsRequired(false).HasColumnName("PasswordHash").HasColumnType("binary(64)");
            builder.Property(x => x.PasswordSalt).IsRequired(false).HasColumnName("PasswordSalt").HasColumnType("binary(128)");
            builder.Property(x => x.FirstName).IsRequired(false).HasColumnName("FirstName").HasColumnType("nvarchar(50)");
            builder.Property(x => x.LastName).IsRequired(false).HasColumnName("LastName").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Address).IsRequired(false).HasColumnName("Address").HasColumnType("nvarchar(100)");
            builder.Property(x => x.Phone).IsRequired(false).HasColumnName("Phone").HasColumnType("varchar(15)");
            builder.Property(x => x.Email).IsRequired(false).HasColumnName("Name").HasColumnType("varchar(50)");
            builder.Property(x => x.UserStatusTypeId).IsRequired(false).HasColumnName("Status").HasColumnType("int");
            builder.HasOne(x => x.UserStatusType).WithMany(y => y.Users).HasForeignKey(z => z.UserStatusTypeId);
        }
    }
}