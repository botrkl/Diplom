using Microsoft.EntityFrameworkCore;
using OnlineShop.API.Entities;

namespace OnlineShop.API.DbData
{
    public class ProductDataGenerator
    {
        public static readonly List<Product> products = new List<Product>
        {
            new()
            {
                Id = Guid.Parse("16CDD060-3E1F-459E-9D5C-C69374DEA2F8"),
                Name = "Ноутбук Lenovo IdeaPad Slim 3 16ABR8",
                Description = "Екран 16 IPS (1920x1200) WUXGA, матовий / AMD Ryzen 7 7730U (2.0 - 4.5 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.74 кг / сірий",
                Price = 24530m,
                ImageUrl = "https://content.rozetka.com.ua/goods/images/big/334493611.jpg",
                StockQuantity = 10,
                CategoryId = Guid.Parse("946A0305-470A-461A-87E3-8FD62C6DC115")
            },
            new()
            {
                Id = Guid.Parse("89CBCC94-AFE6-4B6F-B959-C1DCF82B1E6A"),
                Name = "Ноутбук Acer Aspire 5 A515-57-59NG",
                Description = "Екран 15.6 IPS (1920x1080) Full HD, матовий / Intel Core i5-12450H (2.0 - 4.4 ГГц) / RAM 32 ГБ / SSD 512 ГБ / Intel Iris Xe Graphics / без ОД / LAN / Wi-Fi / Bluetooth / вебкамера / без ОС / 1.76 кг / сірий",
                Price = 26777m,
                ImageUrl = "https://content1.rozetka.com.ua/goods/images/big/357248068.jpg",
                StockQuantity = 15,
                CategoryId = Guid.Parse("946A0305-470A-461A-87E3-8FD62C6DC115")
            },
            new()
            {
                Id = Guid.Parse("BFEB5B61-D188-4074-8640-0FC5F24BE7B3"),
                Name = "Ідеальний шторм - Д. Райнгардт",
                Description = "Приготуйтеся до шторму, що сколихне увесь світ «Якщо все піде так, як я планував, то через тиждень, 30 серпня 2020 року, світ на хвилину затамує подих. На різних континентах відбуватимуться певні події, на перший погляд, ніяк не пов'язані. Тільки той, хто придивиться до них уважніше, зрозуміє, що насправді це фрагменти однієї й тієї ж історії».",
                Price = 450.5m,
                ImageUrl = "https://content2.rozetka.com.ua/goods/images/big/354966480.jpg",
                StockQuantity = 5,
                CategoryId = Guid.Parse("A7A0B109-23EC-4AF2-AD2C-4149A5888082")
            },
            new()
            {
                Id = Guid.Parse("95449600-D1EB-4377-B9FC-9DD70C0E4C50"),
                Name = "Володар тіні - К. Донато",
                Description = "Року Божого 1521 папа Лев Х видав буллу, в якій було сказано, що Рим ніколи не повинен залишатися в темряві. П’ять століть по тому негода призвела до збоїв у роботі однієї з електростанцій. Щоб усунути пошкодження, постачання електроенергії довелося відключити на добу. І Рим поглинула темрява, пробудивши зло.",
                Price = 240m,
                ImageUrl = "https://content2.rozetka.com.ua/goods/images/big/335210773.jpg",
                StockQuantity = 3,
                CategoryId = Guid.Parse("A7A0B109-23EC-4AF2-AD2C-4149A5888082")
            },
            new()
            {
                Id = Guid.Parse("CB1A499B-A1B6-4E94-95C9-D1DC4653F3A1"),
                Name = "Мішок боксерський Sportko Бочечка",
                Description = "Мішок боксерський SportKo Бочонок PVC з кільцем 75 см черний - ідеальний варіант для домашнього використання.",
                Price = 1175m,
                ImageUrl = "https://content1.rozetka.com.ua/goods/images/big/220901139.png",
                StockQuantity = 7,
                CategoryId = Guid.Parse("96CCF359-94B9-4FAD-A857-6FD2E4C6519F")
            }
        };
        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasData(products);
        }
    }
}
