namespace OnlineStore.DAL.Entities
{
    public class ProductImage : BaseEntity
    {
        public string Url { get; set; } = default!;
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
