using Microsoft.Extensions.DependencyInjection;
using OnlineStore.BLL.Services.Classes;
using OnlineStore.BLL.Services.Interfaces;

namespace OnlineStore.BLL.Extensions
{
    public static class AddServices
    {
        public static void AddServiceInjection(this IServiceCollection services)
        {
            services.AddScoped<IHashService, HashService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IReviewService, ReviewService>();

            services.AddAutoMapper(typeof(AppMappingProfile));
        }
    }
}