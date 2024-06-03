namespace OnlineStore.API.DTOs
{
    public class ProductImageDto
    {
        public Guid Id { get; set; }
        public string Url { get; set; } = default!;
        public Guid ProductId { get; set; }
    }
}