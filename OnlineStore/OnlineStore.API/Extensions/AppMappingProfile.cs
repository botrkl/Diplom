using AutoMapper;
using OnlineStore.API.DTOs;
using OnlineStore.BLL.Models;

namespace OnlineStore.API.Extensions
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile()
        {
            CreateMap<CategoryModel, CategoryDto>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Name,
                    opt => opt.MapFrom(item => item.Name))
                .ForMember(item => item.ParentCategoryId,
                    opt => opt.MapFrom(item => item.ParentCategoryId.ToString()))
                .ForMember(item => item.SubCategories,
                    opt => opt.MapFrom(src => src.SubCategories));

            CreateMap<CategoryDto, CategoryModel>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Name,
                    opt => opt.MapFrom(item => item.Name))
                .ForMember(item => item.ParentCategoryId,
                    opt => opt.MapFrom(item => item.ParentCategoryId))
                .ForMember(item => item.SubCategories,
                    opt => opt.MapFrom(src => src.SubCategories));

            CreateMap<ProductModel, ProductDto>()
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

            CreateMap<ProductDto, ProductModel>()
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

            CreateMap<ProductImageModel, ProductImageDto>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Url,
                    opt => opt.MapFrom(item => item.Url))
                .ForMember(item => item.ProductId,
                    opt => opt.MapFrom(item => item.ProductId));

            CreateMap<ProductImageDto, ProductImageModel>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Url,
                    opt => opt.MapFrom(item => item.Url))
                .ForMember(item => item.ProductId,
                    opt => opt.MapFrom(item => item.ProductId));

            CreateMap<ReviewModel, ReviewDto>()
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

            CreateMap<ReviewDto, ReviewModel>()
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

            CreateMap<UserModel, UserDto>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Name,
                    opt => opt.MapFrom(item => item.Name))
                .ForMember(item => item.Email,
                    opt => opt.MapFrom(item => item.Email))
                .ForMember(item => item.Password,
                    opt => opt.MapFrom(item => item.Password));

            CreateMap<UserDto, UserModel>()
                .ForMember(item => item.Id,
                    opt => opt.MapFrom(item => item.Id))
                .ForMember(item => item.Name,
                    opt => opt.MapFrom(item => item.Name))
                .ForMember(item => item.Email,
                    opt => opt.MapFrom(item => item.Email))
                .ForMember(item => item.Password,
                    opt => opt.MapFrom(item => item.Password));

            CreateMap<RegisterDataDto, UserModel>()
                .ForMember(item => item.Name,
                    opt => opt.MapFrom(item => item.Name))
                .ForMember(item => item.Email,
                    opt => opt.MapFrom(item => item.Email))
                .ForMember(item => item.Password,
                    opt => opt.MapFrom(item => item.Password));

            CreateMap<LoginDataDto, UserModel>()
                .ForMember(item => item.Email,
                    opt => opt.MapFrom(item => item.Email))
                .ForMember(item => item.Password,
                    opt => opt.MapFrom(item => item.Password));
        }
    }
}