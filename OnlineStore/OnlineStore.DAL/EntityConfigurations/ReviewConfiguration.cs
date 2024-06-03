using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.EntityConfigurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.ProductId);
            builder.Property(x => x.UserId);
            builder.Property(x => x.Message);
            builder.Property(x => x.Rating);
        }
    }
}

