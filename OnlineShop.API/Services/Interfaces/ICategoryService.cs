using OnlineShop.API.Entities;

namespace OnlineShop.API.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}
