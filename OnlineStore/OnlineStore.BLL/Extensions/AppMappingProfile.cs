using AutoMapper;
using OnlineStore.BLL.Models;
using OnlineStore.DAL.Entities;

namespace OnlineStore.BLL.Extensions
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<CategoryModel, Category>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Name,
                    opt => opt.MapFrom(item => item.Name))
                .ForMember(item => item.ParentCategoryId,
                    opt => opt.MapFrom(item => item.ParentCategoryId))
                .ForMember(item => item.SubCategories,
                    opt => opt.MapFrom(src => src.SubCategories));

            CreateMap<Category, CategoryModel>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(item => item.Name,
                    opt => opt.MapFrom(src => src.Name))
                .ForMember(item => item.ParentCategoryId,
                    opt => opt.MapFrom(src => src.ParentCategoryId))
                .ForMember(item => item.SubCategories,
                    opt => opt.MapFrom(src => src.SubCategories));

            CreateMap<ProductModel, Product>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.CategoryId,
                    opt => opt.MapFrom(item => item.CategoryId))
                .ForMember(item => item.Title,
                    opt => opt.MapFrom(item => item.Title))
                .ForMember(item => item.Description,
                    opt => opt.MapFrom(item => item.Description))
                .ForMember(item => item.PreviewImage,
                    opt => opt.MapFrom(item => item.PreviewImage))
                .ForMember(item => item.Rating,
                    opt => opt.MapFrom(item => item.Rating))
                .ForMember(item => item.Price,
                    opt => opt.MapFrom(item => item.Price));

            CreateMap<Product, ProductModel>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.CategoryId,
                    opt => opt.MapFrom(item => item.CategoryId))
                .ForMember(item => item.Title,
                    opt => opt.MapFrom(item => item.Title))
                .ForMember(item => item.Description,
                    opt => opt.MapFrom(item => item.Description))
                .ForMember(item => item.PreviewImage,
                    opt => opt.MapFrom(item => item.PreviewImage))
                .ForMember(item => item.Rating,
                    opt => opt.MapFrom(item => item.Rating))
                .ForMember(item => item.Price,
                    opt => opt.MapFrom(item => item.Price))
                .ForMember(item => item.ProductImages,
                    opt => opt.MapFrom(item => item.ProductImages))
                .ForMember(item => item.Reviews,
                    opt => opt.MapFrom(item => item.Reviews));

            CreateMap<ProductImageModel, ProductImage>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Url,
                    opt => opt.MapFrom(item => item.Url))
                .ForMember(item => item.ProductId,
                    opt => opt.MapFrom(item => item.ProductId));

            CreateMap<ProductImage, ProductImageModel>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Url,
                    opt => opt.MapFrom(item => item.Url))
                .ForMember(item => item.ProductId,
                    opt => opt.MapFrom(item => item.ProductId));

            CreateMap<ReviewModel, Review>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Message,
                    opt => opt.MapFrom(item => item.Message))
                .ForMember(item => item.Rating,
                    opt => opt.MapFrom(item => item.Rating))
                .ForMember(item => item.ProductId,
                    opt => opt.MapFrom(item => item.ProductId))
                .ForMember(item => item.UserId,
                    opt => opt.MapFrom(item => item.UserId))
                .ForMember(item => item.Date,
                    opt => opt.MapFrom(item => item.Date));

            CreateMap<Review, ReviewModel>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Message,
                    opt => opt.MapFrom(item => item.Message))
                .ForMember(item => item.Rating,
                    opt => opt.MapFrom(item => item.Rating))
                .ForMember(item => item.ProductId,
                    opt => opt.MapFrom(item => item.ProductId))
                .ForMember(item => item.UserId,
                    opt => opt.MapFrom(item => item.UserId))
                .ForMember(item => item.Date,
                    opt => opt.MapFrom(item => item.Date))
                .ForMember(item => item.User,
                    opt => opt.MapFrom(item => item.User));

            CreateMap<UserModel, User>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Name,
                    opt => opt.MapFrom(item => item.Name))
                .ForMember(item => item.Email,
                    opt => opt.MapFrom(item => item.Email))
                .ForMember(item => item.Password,
                    opt => opt.MapFrom(item => item.Password));

            CreateMap<User, UserModel>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Name,
                    opt => opt.MapFrom(item => item.Name))
                .ForMember(item => item.Email,
                    opt => opt.MapFrom(item => item.Email))
                .ForMember(item => item.Password,
                    opt => opt.MapFrom(item => item.Password));
        }
    }
}