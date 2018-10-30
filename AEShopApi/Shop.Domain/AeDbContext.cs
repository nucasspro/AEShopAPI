using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entities;
using Shop.Domain.EntitiesConfiguration;

namespace Shop.Domain
{
    public class AeDbContext : DbContext /*, IUnitOfWork*/
    {
        public DbContext Context;

        public AeDbContext()
        {
        }

        public AeDbContext(DbContextOptions<AeDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                return;
            //optionsBuilder.UseSqlServer(Context.Database.GetDbConnection());
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-9VB67KJ; Database = ShopAE5; Trusted_Connection = True; ConnectRetryCount = 0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            modelBuilder.Seed();
        }
    }
}