namespace OnlineStore.API.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string PreviewImage { get; set; } = default!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductImageDto> ProductImages { get; set; } = default!;
        public ICollection<ReviewDto> Reviews { get; set; } = default!;
    }
}