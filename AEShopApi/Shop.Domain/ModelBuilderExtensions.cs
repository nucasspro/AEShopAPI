using Microsoft.EntityFrameworkCore;
using Shop.Domain.Commons;
using Shop.Domain.Entities;
using System;

namespace Shop.Domain
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Category001", ParentId = 1, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new Category { Id = 2, Name = "Category002", ParentId = 1, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new Category { Id = 3, Name = "Category003", ParentId = 2, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new Category { Id = 4, Name = "Category004", ParentId = 2, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new Category { Id = 5, Name = "Category005", ParentId = 1, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) }
            );

            //modelBuilder.Entity<Product>().HasData(
            //    new Product { Id = 1, Sku = "PD001", Name = "Product001", Description = "DescriptionDescriptionDescriptionDescription", RegularPrice = 100000, DiscountPrice = 100000, Quantity = 10, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
            //    new Product { Id = 2, Sku = "PD002", Name = "Product002", Description = "DescriptionDescriptionDescriptionDescription", RegularPrice = 10000, DiscountPrice = 10000, Quantity = 10, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
            //    new Product { Id = 3, Sku = "PD003", Name = "Product003", Description = "DescriptionDescriptionDescriptionDescription", RegularPrice = 1000, DiscountPrice = 1000, Quantity = 10, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
            //    new Product { Id = 4, Sku = "PD004", Name = "Product004", Description = "DescriptionDescriptionDescriptionDescription", RegularPrice = 100, DiscountPrice = 100, Quantity = 10, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) }
            //);

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { ProductId = 1, CategoryId = 1, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new ProductCategory { ProductId = 2, CategoryId = 1, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new ProductCategory { ProductId = 3, CategoryId = 2, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) },
                new ProductCategory { ProductId = 4, CategoryId = 4, InsertedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now), UpdatedAt = ConvertDatetime.ConvertToTimeSpan(DateTime.Now) }
            );
        }
    }
}