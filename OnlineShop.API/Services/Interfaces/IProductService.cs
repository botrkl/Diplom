using OnlineShop.API.Entities;

namespace OnlineShop.API.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(Guid categoryId);
        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
