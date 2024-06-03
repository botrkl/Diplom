namespace OnlineStore.API.DTOs
{
    public class ReviewDto
    {
        public Guid? Id { get; set; }
        public string Message { get; set; } = default!;
        public int Rating { get; set; }
        public Guid ProductId { get; set; }
        public Guid? UserId { get; set; }
        public DateTime Date { get; set; }
        public UserDto? User { get; set; } = default!;
    }
}