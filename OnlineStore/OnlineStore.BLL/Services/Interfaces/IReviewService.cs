using OnlineStore.BLL.Models;

namespace OnlineStore.BLL.Services.Interfaces
{
    public interface IReviewService
    {
        Task AddReview(ReviewModel model);
    }
}