using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Entities;

namespace OnlineShop.API.DbData
{
    public class OrderDataGenerator
    {
        public static readonly List<Order> orders = new List<Order>
        {
            new()
            {
                Id = Guid.Parse("92DAA1C6-86F9-43B6-9064-AA2B4C9958A8"),
                CustomerName = "Olexander",
                CustomerEmail = "olexander@gmail.com",
                OrderDate = DateTime.Now,
                ShippingAddressId = Guid.Parse("1C869FA4-7E41-4EF7-863F-D8CBDBDAE30B")
            },
            new()
            {
                Id = Guid.Parse("D8C7BD81-A34C-4677-B698-DADAC6708B84"),
                CustomerName = "Serhii",
                CustomerEmail = "serhii@gmail.com",
                OrderDate = DateTime.Now,
                ShippingAddressId = Guid.Parse("7128B902-4778-4A3D-975B-AB9C62E8A0C4")
            },
        };

        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasData(orders);
        }
    }
}
