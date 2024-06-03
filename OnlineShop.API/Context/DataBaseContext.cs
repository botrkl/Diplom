using Microsoft.EntityFrameworkCore;
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
            // Category - Product (One-to-Many)
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Order - ShippingAddress (One-to-One)
            modelBuilder.Entity<Order>()
         .HasOne(o => o.ShippingAddress)
         .WithOne(sa => sa.Order) // Виправлено на sa.Order (без дужок)
         .HasForeignKey<Order>(o => o.ShippingAddressId)
         .OnDelete(DeleteBehavior.Cascade);

            // Order - OrderItem (One-to-Many)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // OrderItem - Product (Many-to-One)
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId);

            // Indexes
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.CategoryId);
            modelBuilder.Entity<OrderItem>()
                .HasIndex(oi => oi.OrderId);
            modelBuilder.Entity<OrderItem>()
                .HasIndex(oi => oi.ProductId);
        }
    }
}
