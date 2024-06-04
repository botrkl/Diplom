using Microsoft.EntityFrameworkCore;
using OnlineShop.API.DbData;
using OnlineShop.API.Entities;

namespace OnlineShop.API.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShippingAddress> ShippingAddresses { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.ShippingAddress)
                .WithOne(sa => sa.Order) 
                .HasForeignKey<Order>(o => o.ShippingAddressId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.CategoryId);
            modelBuilder.Entity<OrderItem>()
                .HasIndex(oi => oi.OrderId);
            modelBuilder.Entity<OrderItem>()
                .HasIndex(oi => oi.ProductId);

            CategoryDataGenerator.Generate(modelBuilder);
            OrderDataGenerator.Generate(modelBuilder);
            OrderItemDataGenerator.Generate(modelBuilder);
            ProductDataGenerator.Generate(modelBuilder);
            ShippingAddressDataGenerator.Generate(modelBuilder);
        }
    }
}
