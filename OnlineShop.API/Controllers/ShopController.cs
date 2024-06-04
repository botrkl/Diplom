using Microsoft.AspNetCore.Mvc;
using OnlineShop.API.Entities;
using OnlineShop.API.Services.Interfaces;

namespace OnlineShop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShopController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;

        public ShopController(ICategoryService categoryService, IProductService productService, IOrderService orderService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
        }

        [HttpGet("categories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            return Ok(categories);
        }

        [HttpGet("categories/{categoryId}/products")]
        public async Task<IActionResult> GetAllProductsByCategory(Guid categoryId)
        {
            var products = await _productService.GetProductsByCategoryIdAsync(categoryId);
            return Ok(products);
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpPost("order/add")]
        public async Task<IActionResult> AddOrder([FromBody] Order order)
        {
            var orderId = await _orderService.CreateOrderAsync(order);
            return CreatedAtAction(nameof(GetOrderById), new { orderId }, orderId);
        }

        [HttpGet("orders/{orderId}")]
        public async Task<IActionResult> GetOrderById(Guid orderId)
        {
            var order = await _orderService.GetOrderByIdAsync(orderId);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }
    }
}
