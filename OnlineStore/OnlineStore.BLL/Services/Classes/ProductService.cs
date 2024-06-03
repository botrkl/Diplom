using AutoMapper;
using OnlineStore.BLL.Models;
using OnlineStore.BLL.Services.Interfaces;
using OnlineStore.DAL.Repositories.Interfaces;

namespace OnlineStore.BLL.Services.Classes
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ProductModel?> GetProduct(Guid id)
        {
            var product = await _productRepository.GetProduct(id);
            return _mapper.Map<ProductModel>(product);
        }

        public async Task<IEnumerable<ProductModel>> GetProductsInCategories(ICollection<Guid> ids)
        {
            var products = await _productRepository.GetProductsInCategories(ids);
            return _mapper.Map<IEnumerable<ProductModel>>(products);
        }

        public async Task<IEnumerable<ProductModel>> GetBestSelling()
        {
            var products = await _productRepository.GetBestSelling();
            return _mapper.Map<IEnumerable<ProductModel>>(products);
        }

        public async Task<IEnumerable<ProductModel>> GetBestSellingInCategory(Guid id)
        {
            var products = await _productRepository.GetBestSellingInCategory(id);
            return _mapper.Map<IEnumerable<ProductModel>>(products);
        }

        public async Task<IEnumerable<ProductModel>> GetRecentPurchases()
        {
            var products = await _productRepository.GetRecentPurchases();
            return _mapper.Map<IEnumerable<ProductModel>>(products);
        }
    }
}