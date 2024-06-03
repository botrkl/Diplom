using OnlineStore.BLL.Models;

namespace OnlineStore.BLL.Services.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> GetAllCategories();
    }
}