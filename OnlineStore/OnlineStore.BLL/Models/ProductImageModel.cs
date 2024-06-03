namespace OnlineStore.BLL.Models
{
    public class ProductImageModel : BaseModel
    {
        public string Url { get; set; } = default!;
        public Guid ProductId { get; set; }
    }
}