using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using Shop.Domain.EntitiesConfiguration;

namespace Shop.Domain
{
    public class AeDbContext : DbContext
    {
        public DbContext Context;

        public AeDbContext()
        {
        }

        public AeDbContext(DbContextOptions<AeDbContext> options) : base(options)
        {
        }

        #region MyRegion Add DbSet<T>

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryStatusType> CategoryStatusTypes { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountActiveType> DiscountActiveTypes { get; set; }
        public DbSet<DiscountRedeemType> DiscountRedeemTypes { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostStatusType> PostStatusTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductStatusType> ProductStatusTypes { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<ShippingProvider> ShippingProviders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserStatusType> UserStatusTypes { get; set; }
        public DbSet<Ward> Wards { get; set; }

        #endregion MyRegion Add DbSet<T>

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;
            //optionsBuilder.UseSqlServer(Context.Database.GetDbConnection());
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-9VB67KJ; Database = Shop8; Trusted_Connection = True; ConnectRetryCount = 0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Add Entity Configurations

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryStatusTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountActiveTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountRedeemTypeConfiguration());
            modelBuilder.ApplyConfiguration(new DistrictsConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new PostCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new PostStatusTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductStatusTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProvinceConfiguration());
            modelBuilder.ApplyConfiguration(new ShippingConfiguration());
            modelBuilder.ApplyConfiguration(new ShippingProviderConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserStatusTypeConfiguration());
            modelBuilder.ApplyConfiguration(new WardConfiguration());

            #endregion Add Entity Configurations

            //modelBuilder.Seed();
        }
    }
}