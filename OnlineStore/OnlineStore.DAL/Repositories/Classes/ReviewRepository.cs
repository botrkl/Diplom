using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Context;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.Repositories.Interfaces;

namespace OnlineStore.DAL.Repositories.Classes
{
    public class ReviewRepository : BaseRepository<Review>, IReviewRepository
    {
        public ReviewRepository(DataBaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Review>> GetReviewsByProductId(Guid productId)
        {
            var product = Context.Reviews
                .Include(x => x.User)
                .Where(p => p.ProductId == productId).ToList();

            return product;
        }
    }
}