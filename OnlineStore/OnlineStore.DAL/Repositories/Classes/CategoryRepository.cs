using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Context;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.Repositories.Interfaces;

namespace OnlineStore.DAL.Repositories.Classes
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DataBaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await Context.Categories.Include(x => x.SubCategories).ToListAsync();
        }
    }
}