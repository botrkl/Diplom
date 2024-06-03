namespace OnlineStore.DAL.Entities
{
    public class Product : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string PreviewImage { get; set; } = default!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<ProductImage>? ProductImages { get; set; }
        public virtual ICollection<Review>? Reviews { get; set; }
        public virtual Category? Category { get; set; }
    }
}

