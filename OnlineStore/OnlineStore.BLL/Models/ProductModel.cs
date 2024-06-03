namespace OnlineStore.BLL.Models
{
    public class ProductModel : BaseModel
    {
        public Guid CategoryId { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string PreviewImage { get; set; } = default!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductImageModel> ProductImages { get; set; } = default!;
        public ICollection<ReviewModel> Reviews { get; set; } = default!;
    }
}