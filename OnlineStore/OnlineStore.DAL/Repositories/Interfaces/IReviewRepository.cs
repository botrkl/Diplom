using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.Repositories.Interfaces
{
    public interface IReviewRepository : IBaseRepository<Review>
    {
        Task<IEnumerable<Review>> GetReviewsByProductId(Guid productId);
    }
}