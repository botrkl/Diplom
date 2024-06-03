using AutoMapper;
using OnlineStore.BLL.Models;
using OnlineStore.BLL.Services.Interfaces;
using OnlineStore.DAL.Repositories.Interfaces;

namespace OnlineStore.BLL.Services.Classes
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryModel>> GetAllCategories()
        {
            var categories = (await _categoryRepository.GetAllCategories()).Where(c => c.ParentCategoryId == null);
            return _mapper.Map<IEnumerable<CategoryModel>>(categories);
        }
    }
}