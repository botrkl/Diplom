using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Entities;

namespace OnlineShop.API.DbData
{
    public class ShippingAddressDataGenerator
    {
        public static readonly List<ShippingAddress> shippingAddresses = new List<ShippingAddress>
        {
            new()
            {
                Id = Guid.Parse("1C869FA4-7E41-4EF7-863F-D8CBDBDAE30B"),
                Country = "Україна",
                City = "Київ",
                Street = "Хрещатик",
                HouseNumber = 11,
                OrderId = Guid.Parse("92DAA1C6-86F9-43B6-9064-AA2B4C9958A8")
            },
            new()
            {
                Id = Guid.Parse("7128B902-4778-4A3D-975B-AB9C62E8A0C4"),
                Country = "Україна",
                City = "Кропивницький",
                Street = "Соборна",
                HouseNumber = 8,
                OrderId = Guid.Parse("D8C7BD81-A34C-4677-B698-DADAC6708B84")
            },
        };
        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<ShippingAddress>()
                .HasData(shippingAddresses);
        }
    }
}