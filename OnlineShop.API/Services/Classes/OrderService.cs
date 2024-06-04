using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Context;
using OnlineShop.API.Entities;
using OnlineShop.API.Services.Interfaces;

namespace OnlineShop.API.Services.Classes
{
    public class OrderService : IOrderService
    {
        private readonly DataBaseContext _context;

        public OrderService(DataBaseContext context)
        {
            _context = context;
        }
        public async Task<Guid> CreateOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order.Id;
        }
        public async Task<Order> GetOrderByIdAsync(Guid orderId)
        {
            return await _context.Orders
                .Where(o => o.Id == orderId)
                .Include(o => o.ShippingAddress)
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(); 
        }
    }
}
