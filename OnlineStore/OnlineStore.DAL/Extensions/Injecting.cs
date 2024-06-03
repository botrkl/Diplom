using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineStore.DAL.Context;
using OnlineStore.DAL.Repositories.Classes;
using OnlineStore.DAL.Repositories.Interfaces;

namespace OnlineStore.DAL.Extensions
{
    public static class Injecting
    {
        public static void InjectDAL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataBaseContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionString"]);
            });
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductImageRepository, ProductImageRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}