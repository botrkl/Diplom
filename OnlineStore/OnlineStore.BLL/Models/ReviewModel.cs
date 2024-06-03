namespace OnlineStore.BLL.Models
{
    public class ReviewModel : BaseModel
    {
        public string Message { get; set; } = default!;
        public int Rating { get; set; }
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public UserModel User { get; set; } = default!;
    }
}