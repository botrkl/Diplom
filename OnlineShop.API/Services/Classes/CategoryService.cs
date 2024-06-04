using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Context;
using OnlineShop.API.Entities;
using OnlineShop.API.Services.Interfaces;

namespace OnlineShop.API.Services.Classes
{
    public class CategoryService : ICategoryService
    {
        private readonly DataBaseContext _context;

        public CategoryService(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

    }
}
