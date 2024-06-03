using OnlineStore.BLL.Models;

namespace OnlineStore.BLL.Services.Interfaces
{
    public interface IProductService
    {
        Task<ProductModel?> GetProduct(Guid id);
        Task<IEnumerable<ProductModel>> GetProductsInCategories(ICollection<Guid> ids);
        Task<IEnumerable<ProductModel>> GetBestSelling();
        Task<IEnumerable<ProductModel>> GetBestSellingInCategory(Guid id);
        Task<IEnumerable<ProductModel>> GetRecentPurchases();
    }
}