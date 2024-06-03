using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Context;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.Repositories.Interfaces;

namespace OnlineStore.DAL.Repositories.Classes
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly IReviewRepository _reviewRepository;

        public ProductRepository(DataBaseContext context, IReviewRepository reviewRepository) : base(context)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<Product?> GetProduct(Guid id)
        {
            var product = await Context.Products
                .Include(x => x.ProductImages)
                .FirstOrDefaultAsync(p => p.Id == id);
            var reviews = await _reviewRepository.GetReviewsByProductId(product!.Id);
            product.Reviews = reviews.ToList();

            return product;
        }

        public async Task<IEnumerable<Product?>> GetProductsInCategories(ICollection<Guid> ids)
        {
            var products = GetProductsInCategoryAndSubcategories(ids);
            return products;
        }

        public async Task<IEnumerable<Product?>> GetBestSelling()
        {
            var products = GetAll();
            var random = new Random();
            var randomProducts =
                products
                    .OrderBy(p => random.Next())
                    .Take(5);
            return randomProducts;
        }


        public async Task<IEnumerable<Product?>> GetBestSellingInCategory(Guid id)
        {
            var productsInCategory = GetProductsInCategoryAndSubcategories(new List<Guid> { id });
            var random = new Random();
            var randomProducts = productsInCategory
                .OrderBy(p => random.Next())
                .Take(5);
            return randomProducts;
        }

        public async Task<IEnumerable<Product?>> GetRecentPurchases()
        {
            var products = GetAll();
            var random = new Random();
            var randomProducts =
                products
                    .OrderBy(p => random.Next())
                    .Take(5); 
            return randomProducts;
        }

        private IEnumerable<Product> GetProductsInCategoryAndSubcategories(ICollection<Guid> ids)
        {
            var processedCategories = new HashSet<Guid>();
            var products = new List<Product>();
            foreach (var categoryId in ids)
            {
                GetProductsRecursively(categoryId, ref products, processedCategories);
            }
            return products;
        }

        private void GetProductsRecursively(Guid categoryId, ref List<Product> products, HashSet<Guid> processedCategories)
        {
            if (processedCategories.Contains(categoryId))
                return;

            processedCategories.Add(categoryId);

            var productsInCategory = Context.Products
                .Where(p => p.CategoryId == categoryId)
                .ToList();

            products.AddRange(productsInCategory);

            var subcategories = Context.Categories
                .Where(c => c.ParentCategoryId == categoryId)
                .ToList();

            if (!subcategories.Any())
                return;

            foreach (var subcategory in subcategories)
            {
                GetProductsRecursively(subcategory.Id, ref products, processedCategories);
            }
        }

    }
}