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

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }
        public virtual DbSet<ShippingProvider> ShippingProviders { get; set; }
        //public virtual DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;
            //optionsBuilder.UseSqlServer(Context.Database.GetDbConnection());
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-9VB67KJ; Database = ShopAE5; Trusted_Connection = True; ConnectRetryCount = 0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountsConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ShippingConfiguration());
            modelBuilder.ApplyConfiguration(new ShippingProviderConfiguration());

            //modelBuilder.Seed();
        }
    }
}