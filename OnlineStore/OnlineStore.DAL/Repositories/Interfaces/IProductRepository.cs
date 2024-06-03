using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.Repositories.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<Product?> GetProduct(Guid id);
        Task<IEnumerable<Product?>> GetProductsInCategories(ICollection<Guid> ids);
        Task<IEnumerable<Product?>> GetBestSelling();
        Task<IEnumerable<Product?>> GetBestSellingInCategory(Guid id);
        Task<IEnumerable<Product?>> GetRecentPurchases();
    }
}