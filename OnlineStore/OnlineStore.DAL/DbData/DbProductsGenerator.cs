using Microsoft.EntityFrameworkCore;
using OnlineStore.DAL.Entities;

namespace OnlineStore.DAL.DbData
{
    public static class DbProductsGenerator
    {
        public static readonly List<Product> Products = new List<Product>
    {
        new ()
        {
            Id = new Guid("d83b8d3d-03f6-4975-b6f4-4b2c7791468d"),
            CategoryId = new Guid("b1a2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Title = "Mobile phone Apple iPhone 11 128GB Black",
            Description = "Screen (6.1\", IPS (Liquid Retina HD), 1792x828) / Apple A13 Bionic / main dual camera: 12 MP + 12 MP, front camera: 12 MP / RAM 4 GB / 128 GB built-in memory / 3G / LTE / GPS / GLONASS / Nano-SIM / iOS 13 / 3046 mAh",
            PreviewImage = "https://content.rozetka.com.ua/goods/images/big_tile/37399227.png",
            Rating = 4,
            Price = 564.14m,
        },
        new ()
        {
            Id = new Guid("79a8b7b1-5b5c-4096-bf59-2f5d491949d9"),
            CategoryId = new Guid("b1a2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Title = "Mobile phone Apple iPhone 15 Pro Max 256GB Natural Titanium",
            Description = "Screen (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / main triple camera: 48 MP + 12 MP + 12 MP, front camera: 12 MP / 256 GB of built-in memory / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17",
            PreviewImage = "https://content1.rozetka.com.ua/goods/images/big_tile/364834251.jpg",
            Rating = 5,
            Price = 1436.04m,
        },
        new ()
        {
            Id = new Guid("6d526229-d129-4b10-b671-949942b64645"),
            CategoryId = new Guid("b1a2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Title = "Mobile phone Apple iPhone 13 128GB Starlight",
            Description = "Screen (6.1\", OLED (Super Retina XDR), 2532x1170) / Apple A15 Bionic / dual main camera: 12 MP + 12 MP, front camera: 12 MP / 128 GB of built-in memory / 3G / LTE / 5G / GPS / Nano-SIM, eSIM / iOS 15",
            PreviewImage = "https://content1.rozetka.com.ua/goods/images/big_tile/221027910.jpg",
            Rating = 4,
            Price = 692.34m,
        },
        new ()
        {
            Id = new Guid("f4a17b45-d6f6-4922-80a1-8cb09ac6958c"),
            CategoryId = new Guid("91a2b3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Title = "Mobile phone Samsung Galaxy A24 6/128GB Black",
            Description = "Screen (6.5\", Super AMOLED, 2340x1080) / Mediatek Helio G99 (2 x 2.6 GHz + 6 x 2.0 GHz) / main triple camera: 50 MP + 5 MP + 2 MP, front camera: 13 MP / RAM 6 GB / 128 GB of built-in memory + microSD (up to 1 TB) / 3G / LTE / GPS / GLONASS / BDS / support for 2 SIM cards (Nano-SIM) / Android 13 / 5000 mAh",
            PreviewImage = "https://content.rozetka.com.ua/goods/images/big_tile/328132326.jpg",
            Rating = 3,
            Price = 194.87m,
        },
        new ()
        {
            Id = new Guid("b7df95a3-c2bc-4c3a-91bb-d92776959bd7"),
            CategoryId = new Guid("91a2b3d4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Title = "Mobile phone Samsung Galaxy S23 Ultra 12/256GB Beige",
            Description = "Screen (6.8\", Dynamic AMOLED 2X, 3088x1440) / Qualcomm Snapdragon 8 Gen 2 for Galaxy (3.36 GHz + 2.8 GHz + 2.8 GHz + 2.0 GHz) / main quad camera: 10 MP front 12 MP / RAM 12 GB / 256 GB built-in memory / 3G / LTE / 5G / GPS / support for 2x SIM-cards (Nano-SIM) / Android 13 / 5000 mAh * h",
            PreviewImage = "https://content2.rozetka.com.ua/goods/images/big_tile/310655416.jpg",
            Rating = 4,
            Price = 692.34m,
        },
        new ()
        {
            Id = new Guid("c67c49f3-71cf-4a3f-89b0-0056fbcb1107"),
            CategoryId = new Guid("71a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Title = "Apple Watch SE (2023) GPS 40mm Starlight Aluminum Case with Starlight Sport Band - S/M",
            Description = "Your important companions are now even more powerful. Accident detection to get help in an emergency. Stages of sleep to better understand your sleep. As well as new ways to train with the enhanced Workout app. The future of healthcare has never looked so good.",
            PreviewImage = "https://content.rozetka.com.ua/goods/images/big_tile/364852941.jpg",
            Rating = 5,
            Price = 282.06m,
        },
        new ()
        {
            Id = new Guid("3b1b1bb2-655f-4689-8d88-70f9792dc842"),
            CategoryId = new Guid("71a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Title = "Smart watch Samsung Galaxy Watch 6 44mm Black",
            Description = "The watch that knows everything about you returns with a personalized fitness interface and improved sleep tracking. Galaxy Watch6 now features Sleep Tips to help you start your day with a good night's sleep.",
            PreviewImage = "https://content1.rozetka.com.ua/goods/images/big_tile/353760040.jpg",
            Rating = 3,
            Price = 261.54m,
        },
        new ()
        {
            Id = new Guid("04c13a1a-2324-4d5c-aa54-20c2a07a0a8b"),
            CategoryId = new Guid("81a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"),
            Title = "Fitness bracelet Xiaomi Mi Smart Band 8 Pro Black",
            Description = "The gadget provides accurate monitoring based on a two-channel module. Blood oxygen level control has become 10% more accurate. With its help, you can monitor a dozen of user health parameters: from heart rate to sleep quality. Going to training? You can record an activity track without using a smartphone. In basic mode, the device works for 14 days. The voice assistant makes it possible to use the functionality of the device to the maximum.",
            PreviewImage = "https://content2.rozetka.com.ua/goods/images/big_tile/412885387.jpg",
            Rating = 4,
            Price = 76.91m,
        },
        new ()
        {
            Id = new Guid("b9a06fd0-9d17-4901-b998-7b193980f1fd"),
            CategoryId = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b41"),
            Title = "Oversized Women's Nike Air Fleece Crew Sweatshirt FN1897-675 S Playful Pink/Photon Dust",
            Description = "Go retro and modern with this Nike W Nsw Air Oos Flc Crew Sweatshirt. Soft and pleasant to the touch fabric of medium density provides breathability, so it can be worn all year round. The loose fit and dropped shoulder line enhance the bold and carefree vibe.",
            PreviewImage = "https://content2.rozetka.com.ua/goods/images/big_tile/398539813.jpg",
            Rating = 5,
            Price = 107.45m,
        },
        new ()
        {
            Id = new Guid("f89271d8-92d4-4d4a-9142-0919908307a3"),
            CategoryId = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b41"),
            Title = "Women's autumn long coat OZZE D363-1 48 Milk",
            Description = "Copper coat with a slit. Fastens with hidden buttons, has a belt. Raglan sleeve. The coat has laconic pockets.",
            PreviewImage = "https://content2.rozetka.com.ua/goods/images/big_tile/365162840.jpg",
            Rating = 4,
            Price = 86.93m,
        },
        new ()
        {
            Id = new Guid("5a3bb2f4-5b89-46c5-9d15-d3d05c4f3886"),
            CategoryId = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b40"),
            Title = "Demi-season hooded jacket for men Columbia Silver Falls Hooded Jacket 2034501-023 M Gray",
            Description = "The Columbia Silver Falls Hooded Jacket is a versatile and comfortable layer at any time of the year. Synthetic insulation provides warmth without weight, and the jacket folds into its own pocket, perfect for travel.",
            PreviewImage = "https://content1.rozetka.com.ua/goods/images/big_tile/371935662.jpg",
            Rating = 5,
            Price = 78.27m,
        },
        new ()
        {
            Id = new Guid("29f11039-71f6-47ab-b498-2cbf9c1c28aa"),
            CategoryId = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b40"),
            Title = "Men's demi-season jacket s.Oliver 10.3.11.16.160.2140534-7450 2XL Green",
            Description = "Men's demi-season jacket s.Oliver is a stylish combination of comfort and practicality. Mid-length and with a zipper, it will easily fit into your everyday look. Two side pockets and an additional zip pocket on the chest make this jacket not only fashionable but also functional. A simple and secure zip closure provides extra comfort on chilly days.",
            PreviewImage = "https://content1.rozetka.com.ua/goods/images/big_tile/394186890.jpg",
            Rating = 3,
            Price = 82.04m,
        },
        new ()
        {
            Id = new Guid("03223da7-6b63-4d52-a84d-2cb9ac560af7"),
            CategoryId = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b42"),
            Title = "Teenage demi-season jacket for boy 164 cm Khaki",
            Description = "Membrane trekking jacket for boys from 4F. The model is made of technical material with a hydrophobic coating. The NeoDry 5000/3000 membrane is used, which is supplemented with taped critical seams. They will protect against moisture absorption during light rainfall. The jacket will also work well in urban environments.",
            PreviewImage = "https://content.rozetka.com.ua/goods/images/big_tile/358606821.jpg",
            Rating = 5,
            Price = 49.72m,
        },
        new ()
        {
            Id = new Guid("c2f34b8c-446d-4917-8d84-b575ca0d5a4d"),
            CategoryId = new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b42"),
            Title = "Children's sweatshirt for girls Nike G Nsw Flc Ovrszd Crew Lbr XS 122-128 cm Adobe/White",
            Description = "This oversized sweatshirt from Nike has plenty of arm and body room, so you'll always feel comfortable and relaxed wherever you are. Smooth on the outside and soft on the inside, this lightweight fleece is great when you need a little extra warmth. An embroidered Futura logo on the chest gives this crew neck a signature Club Fleece look.",
            PreviewImage = "https://content1.rozetka.com.ua/goods/images/big_tile/419197501.jpg",
            Rating = 4,
            Price = 55.11m,
        }
    };

        public static void Generate(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasData(Products);
        }
    }
}