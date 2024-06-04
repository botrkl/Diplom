using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Entities;

namespace OnlineShop.API.DbData
{
    public class OrderItemDataGenerator
    {
        public static readonly List<OrderItem> orderItems = new List<OrderItem>
        {
            new()
            {
                Id = Guid.Parse("51841A8B-5BA6-422F-A24F-EA1B36E9EE90"),
                Quantity = 1,
                OrderId = Guid.Parse("92DAA1C6-86F9-43B6-9064-AA2B4C9958A8"),
                ProductId = Guid.Parse("BFEB5B61-D188-4074-8640-0FC5F24BE7B3")
            },
            new()
            {
                Id = Guid.Parse("09299418-34DE-47C4-BDB7-A1F4725E6A42"),
                Quantity = 1,
                OrderId = Guid.Parse("92DAA1C6-86F9-43B6-9064-AA2B4C9958A8"),
                ProductId = Guid.Parse("95449600-D1EB-4377-B9FC-9DD70C0E4C50")
            },
            new()
            {
                Id = Guid.Parse("7A729C57-6A52-49BD-8418-A4A55362D3E7"),
                Quantity = 1,
                OrderId = Guid.Parse("D8C7BD81-A34C-4677-B698-DADAC6708B84"),
                ProductId = Guid.Parse("CB1A499B-A1B6-4E94-95C9-D1DC4653F3A1")
            }
        };
        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<OrderItem>()
                .HasData(orderItems);
        }
    }
}
