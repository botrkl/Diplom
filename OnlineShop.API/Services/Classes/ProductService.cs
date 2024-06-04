using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Context;
using OnlineShop.API.Entities;
using OnlineShop.API.Services.Interfaces;

namespace OnlineShop.API.Services.Classes
{
    public class ProductService : IProductService
    {
        private readonly DataBaseContext _context;

        public ProductService(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(Guid categoryId)
        {
            return await _context.Products
                .Where(p => p.CategoryId == categoryId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
