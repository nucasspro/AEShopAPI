using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Common.Commons;
using Shop.Domain.Entities;
using System;

namespace Shop.Domain.EntitiesConfiguration
{
    public class CategoryStatusTypeConfiguration : BaseConfiguration<CategoryStatusType>
    {
        public override void Configure(EntityTypeBuilder<CategoryStatusType> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Name).IsRequired(false).HasColumnName("Name").HasColumnType("nvarchar(50)");
            builder.HasData(
                new CategoryStatusType { Id = 1, Name = "Actived", InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new CategoryStatusType { Id = 2, Name = "Removed", InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) });
        }
    }
}