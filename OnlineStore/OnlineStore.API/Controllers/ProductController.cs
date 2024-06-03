using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.API.DTOs;
using OnlineStore.BLL.Services.Interfaces;

namespace OnlineStore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] Guid id)
        {
            var product = await _productService.GetProduct(id);
            var mapped = _mapper.Map<ProductDto>(product);
            return Ok(mapped);
        }


        [HttpGet("in-categories")]
        public async Task<IActionResult> GetProductsInCategories([FromQuery] List<Guid> categoryIds)
        {
            var products = await _productService.GetProductsInCategories(categoryIds);
            var mapped = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(mapped);
        }


        [HttpGet("best-selling")]
        public async Task<IActionResult> GetBestSelling()
        {
            var products = await _productService.GetBestSelling();
            var mapped = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(mapped);
        }


        [HttpGet("best-selling-in-category/{id:guid}")]
        public async Task<IActionResult> GetBestSellingInCategory([FromRoute] Guid id)
        {
            var products = await _productService.GetBestSellingInCategory(id);
            var mapped = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(mapped);
        }


        [HttpGet("recent-purchases")]
        public async Task<IActionResult> GetRecentPurchases()
        {
            var products = await _productService.GetRecentPurchases();
            var mapped = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(mapped);
        }
    }
}