namespace OnlineStore.DAL.Entities
{
    public class Review : BaseEntity
    {
        public string Message { get; set; } = default!;
        public int Rating { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public virtual User? User { get; set; }
        public virtual Product? Product { get; set; }
    }
}