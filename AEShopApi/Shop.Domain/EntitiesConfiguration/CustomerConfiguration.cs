using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Domain.Entities;

namespace Shop.Domain.EntitiesConfiguration
{
    public class CustomerConfiguration : BaseConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Username).IsRequired(true).HasColumnName("Username").HasColumnType("varchar(20)");
            builder.Property(x => x.Password).IsRequired(true).HasColumnName("Password").HasColumnType("varchar(100)");
            builder.Property(x => x.FullName).IsRequired(true).HasColumnName("FullName").HasColumnType("nvarchar(50)");
            builder.Property(x => x.Email).IsRequired(true).HasColumnName("Name").HasColumnType("varchar(50)");
            builder.Property(x => x.DateOfBirth).IsRequired(false).HasColumnName("DateOfBirth").HasColumnType("date");
            builder.Property(x => x.Phone).IsRequired(true).HasColumnName("Phone").HasColumnType("varchar(15)");
            builder.Property(x => x.Address).IsRequired(true).HasColumnName("Address").HasColumnType("nvarchar(100)");
            builder.Property(x => x.UserImage).IsRequired(false).HasColumnName("UserImage").HasColumnType("varchar(100)");
            builder.Property(x => x.Gender).IsRequired(true).HasColumnName("Gender").HasColumnType("bit").HasDefaultValueSql("0");
            builder.Property(x => x.IsActive).IsRequired(true).HasColumnName("IsActice").HasColumnType("bit").HasDefaultValueSql("0");
        }
    }
}