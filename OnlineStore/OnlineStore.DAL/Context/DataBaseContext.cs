using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.DbData;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.EntityConfigurations;

namespace OnlineStore.DAL.Context
{
    public class DataBaseContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; } = default!;
        public virtual DbSet<Product> Products { get; set; } = default!;
        public virtual DbSet<ProductImage> ProductImages { get; set; } = default!;
        public virtual DbSet<Review> Reviews { get; set; } = default!;
        public virtual DbSet<User> Users { get; set; } = default!;


        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);

            DbCategoriesGenerator.Generate(modelBuilder);
            DbProductsGenerator.Generate(modelBuilder);
            DbProductImagesGenerator.Generate(modelBuilder);
        }
    }
}