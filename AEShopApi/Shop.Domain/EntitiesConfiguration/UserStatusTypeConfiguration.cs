using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Common.Commons;
using Shop.Domain.Entities;
using System;

namespace Shop.Domain.EntitiesConfiguration
{
    public class UserStatusTypeConfiguration : BaseConfiguration<UserStatusType>
    {
        public override void Configure(EntityTypeBuilder<UserStatusType> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(50)");

            builder.HasData(
                new UserStatusType { Id = 1, Name = "Deactivated", InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new UserStatusType { Id = 2, Name = "Activated", InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new UserStatusType { Id = 3, Name = "Removed", InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) });
        }
    }
}