using OnlineShop.API.Entities;

namespace OnlineShop.API.Services.Interfaces
{
    public interface IOrderService
    {
        Task<Guid> CreateOrderAsync(Order order);
        Task<Order> GetOrderByIdAsync(Guid orderId); // Add this line
    }
}
