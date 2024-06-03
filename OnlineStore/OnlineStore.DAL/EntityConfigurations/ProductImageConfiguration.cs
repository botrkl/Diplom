using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.EntityConfigurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.ProductId);
            builder.Property(x => x.Url);
        }
    }
}
