using OnlineStore.DAL.Repositories.Interfaces;
using OnlineStore.DAL.Context;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.Repositories.Classes
{
    public class ProductImageRepository : BaseRepository<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(DataBaseContext context) : base(context)
        {
        }
    }
}