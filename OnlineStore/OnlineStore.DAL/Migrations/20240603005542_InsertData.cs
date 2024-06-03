using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InsertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { new Guid("6f319f69-85dd-4923-ac9f-5acd0b2a1b39"), "Clothing", null },
                    { new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b39"), "Electronics", null },
                    { new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b40"), "Men's Clothing", new Guid("6f319f69-85dd-4923-ac9f-5acd0b2a1b39") },
                    { new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b41"), "Women's Clothing", new Guid("6f319f69-85dd-4923-ac9f-5acd0b2a1b39") },
                    { new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b42"), "Kids' Clothing", new Guid("6f319f69-85dd-4923-ac9f-5acd0b2a1b39") },
                    { new Guid("91a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Gadgets", new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b39") },
                    { new Guid("a1b2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Smartphones", new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b39") },
                    { new Guid("71a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Smartwatches", new Guid("91a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a") },
                    { new Guid("81a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Fitness Trackers", new Guid("91a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a") },
                    { new Guid("91a2b3d4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Samsung", new Guid("a1b2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a") },
                    { new Guid("b1a2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Apple", new Guid("a1b2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "PreviewImage", "Price", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("03223da7-6b63-4d52-a84d-2cb9ac560af7"), new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b42"), "Membrane trekking jacket for boys from 4F. The model is made of technical material with a hydrophobic coating. The NeoDry 5000/3000 membrane is used, which is supplemented with taped critical seams. They will protect against moisture absorption during light rainfall. The jacket will also work well in urban environments.", "https://content.rozetka.com.ua/goods/images/big_tile/358606821.jpg", 49.72m, 5, "Teenage demi-season jacket for boy 164 cm Khaki" },
                    { new Guid("29f11039-71f6-47ab-b498-2cbf9c1c28aa"), new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b40"), "Men's demi-season jacket s.Oliver is a stylish combination of comfort and practicality. Mid-length and with a zipper, it will easily fit into your everyday look. Two side pockets and an additional zip pocket on the chest make this jacket not only fashionable but also functional. A simple and secure zip closure provides extra comfort on chilly days.", "https://content1.rozetka.com.ua/goods/images/big_tile/394186890.jpg", 82.04m, 3, "Men's demi-season jacket s.Oliver 10.3.11.16.160.2140534-7450 2XL Green" },
                    { new Guid("5a3bb2f4-5b89-46c5-9d15-d3d05c4f3886"), new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b40"), "The Columbia Silver Falls Hooded Jacket is a versatile and comfortable layer at any time of the year. Synthetic insulation provides warmth without weight, and the jacket folds into its own pocket, perfect for travel.", "https://content1.rozetka.com.ua/goods/images/big_tile/371935662.jpg", 78.27m, 5, "Demi-season hooded jacket for men Columbia Silver Falls Hooded Jacket 2034501-023 M Gray" },
                    { new Guid("b9a06fd0-9d17-4901-b998-7b193980f1fd"), new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b41"), "Go retro and modern with this Nike W Nsw Air Oos Flc Crew Sweatshirt. Soft and pleasant to the touch fabric of medium density provides breathability, so it can be worn all year round. The loose fit and dropped shoulder line enhance the bold and carefree vibe.", "https://content2.rozetka.com.ua/goods/images/big_tile/398539813.jpg", 107.45m, 5, "Oversized Women's Nike Air Fleece Crew Sweatshirt FN1897-675 S Playful Pink/Photon Dust" },
                    { new Guid("c2f34b8c-446d-4917-8d84-b575ca0d5a4d"), new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b42"), "This oversized sweatshirt from Nike has plenty of arm and body room, so you'll always feel comfortable and relaxed wherever you are. Smooth on the outside and soft on the inside, this lightweight fleece is great when you need a little extra warmth. An embroidered Futura logo on the chest gives this crew neck a signature Club Fleece look.", "https://content1.rozetka.com.ua/goods/images/big_tile/419197501.jpg", 55.11m, 4, "Children's sweatshirt for girls Nike G Nsw Flc Ovrszd Crew Lbr XS 122-128 cm Adobe/White" },
                    { new Guid("f89271d8-92d4-4d4a-9142-0919908307a3"), new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b41"), "Copper coat with a slit. Fastens with hidden buttons, has a belt. Raglan sleeve. The coat has laconic pockets.", "https://content2.rozetka.com.ua/goods/images/big_tile/365162840.jpg", 86.93m, 4, "Women's autumn long coat OZZE D363-1 48 Milk" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("0071eea5-840f-40fa-b52f-aeabeeb1ada1"), new Guid("b9a06fd0-9d17-4901-b998-7b193980f1fd"), "https://content2.rozetka.com.ua/goods/images/big/398539813.jpg" },
                    { new Guid("09567c32-967d-49a1-852a-e4175fd8426e"), new Guid("b9a06fd0-9d17-4901-b998-7b193980f1fd"), "https://content1.rozetka.com.ua/goods/images/big/398539816.jpg" },
                    { new Guid("09a90b9f-6ad2-48a7-9fd7-86e57db2dc35"), new Guid("29f11039-71f6-47ab-b498-2cbf9c1c28aa"), "https://content.rozetka.com.ua/goods/images/big/394186893.jpg" },
                    { new Guid("48d8c4e4-d4a6-4cb0-8818-0ecff110782b"), new Guid("03223da7-6b63-4d52-a84d-2cb9ac560af7"), "https://content.rozetka.com.ua/goods/images/big/358606821.jpg" },
                    { new Guid("613f38e4-68c3-48d0-bb8f-a4c46ef25022"), new Guid("03223da7-6b63-4d52-a84d-2cb9ac560af7"), "https://content2.rozetka.com.ua/goods/images/big/358606835.jpg" },
                    { new Guid("753b7800-f508-4202-ae39-01469bbd0a8b"), new Guid("5a3bb2f4-5b89-46c5-9d15-d3d05c4f3886"), "https://content1.rozetka.com.ua/goods/images/big/371935679.jpg" },
                    { new Guid("a4139af2-e9cf-4473-97c5-49b1b8bd5199"), new Guid("29f11039-71f6-47ab-b498-2cbf9c1c28aa"), "https://content1.rozetka.com.ua/goods/images/big/394186900.jpg" },
                    { new Guid("add4b8a2-8edd-4905-999a-fc4ef8e52f08"), new Guid("f89271d8-92d4-4d4a-9142-0919908307a3"), "https://content.rozetka.com.ua/goods/images/big/365162842.jpg" },
                    { new Guid("b339980d-73fe-4392-93b0-a62f09a7e5dd"), new Guid("03223da7-6b63-4d52-a84d-2cb9ac560af7"), "https://content2.rozetka.com.ua/goods/images/big/358606827.jpg" },
                    { new Guid("b6ac62fb-2a15-4715-9aef-8ae24d42be64"), new Guid("c2f34b8c-446d-4917-8d84-b575ca0d5a4d"), "https://content1.rozetka.com.ua/goods/images/big/419197501.jpg" },
                    { new Guid("c9d46444-4106-4255-b44c-8ce1391b659c"), new Guid("5a3bb2f4-5b89-46c5-9d15-d3d05c4f3886"), "https://content2.rozetka.com.ua/goods/images/big/371935667.jpg" },
                    { new Guid("eedafee0-9371-4d97-9766-f25d9ef7b9c7"), new Guid("c2f34b8c-446d-4917-8d84-b575ca0d5a4d"), "https://content1.rozetka.com.ua/goods/images/big/419197503.jpg" },
                    { new Guid("ef20dc91-c7f8-42bc-8e43-0c86a340838a"), new Guid("29f11039-71f6-47ab-b498-2cbf9c1c28aa"), "https://content1.rozetka.com.ua/goods/images/big/394186890.jpg" },
                    { new Guid("ef60e5c5-78e5-44fa-bac3-3636f00a21c8"), new Guid("5a3bb2f4-5b89-46c5-9d15-d3d05c4f3886"), "https://content1.rozetka.com.ua/goods/images/big/371935662.jpg" },
                    { new Guid("fc7d9af0-7947-49fa-8e2d-fda5e0f49d44"), new Guid("f89271d8-92d4-4d4a-9142-0919908307a3"), "https://content2.rozetka.com.ua/goods/images/big/365162844.jpg" },
                    { new Guid("fe0989ed-1f66-4907-9aad-084e574c7e81"), new Guid("f89271d8-92d4-4d4a-9142-0919908307a3"), "https://content2.rozetka.com.ua/goods/images/big/365162840.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "PreviewImage", "Price", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("04c13a1a-2324-4d5c-aa54-20c2a07a0a8b"), new Guid("81a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"), "The gadget provides accurate monitoring based on a two-channel module. Blood oxygen level control has become 10% more accurate. With its help, you can monitor a dozen of user health parameters: from heart rate to sleep quality. Going to training? You can record an activity track without using a smartphone. In basic mode, the device works for 14 days. The voice assistant makes it possible to use the functionality of the device to the maximum.", "https://content2.rozetka.com.ua/goods/images/big_tile/412885387.jpg", 76.91m, 4, "Fitness bracelet Xiaomi Mi Smart Band 8 Pro Black" },
                    { new Guid("3b1b1bb2-655f-4689-8d88-70f9792dc842"), new Guid("71a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"), "The watch that knows everything about you returns with a personalized fitness interface and improved sleep tracking. Galaxy Watch6 now features Sleep Tips to help you start your day with a good night's sleep.", "https://content1.rozetka.com.ua/goods/images/big_tile/353760040.jpg", 261.54m, 3, "Smart watch Samsung Galaxy Watch 6 44mm Black" },
                    { new Guid("6d526229-d129-4b10-b671-949942b64645"), new Guid("b1a2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Screen (6.1\", OLED (Super Retina XDR), 2532x1170) / Apple A15 Bionic / dual main camera: 12 MP + 12 MP, front camera: 12 MP / 128 GB of built-in memory / 3G / LTE / 5G / GPS / Nano-SIM, eSIM / iOS 15", "https://content1.rozetka.com.ua/goods/images/big_tile/221027910.jpg", 692.34m, 4, "Mobile phone Apple iPhone 13 128GB Starlight" },
                    { new Guid("79a8b7b1-5b5c-4096-bf59-2f5d491949d9"), new Guid("b1a2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Screen (6.7\", OLED (Super Retina XDR), 2796x1290) / Apple A17 Pro / main triple camera: 48 MP + 12 MP + 12 MP, front camera: 12 MP / 256 GB of built-in memory / 3G / LTE / 5G / GPS / Nano-SIM / iOS 17", "https://content1.rozetka.com.ua/goods/images/big_tile/364834251.jpg", 1436.04m, 5, "Mobile phone Apple iPhone 15 Pro Max 256GB Natural Titanium" },
                    { new Guid("b7df95a3-c2bc-4c3a-91bb-d92776959bd7"), new Guid("91a2b3d4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Screen (6.8\", Dynamic AMOLED 2X, 3088x1440) / Qualcomm Snapdragon 8 Gen 2 for Galaxy (3.36 GHz + 2.8 GHz + 2.8 GHz + 2.0 GHz) / main quad camera: 10 MP front 12 MP / RAM 12 GB / 256 GB built-in memory / 3G / LTE / 5G / GPS / support for 2x SIM-cards (Nano-SIM) / Android 13 / 5000 mAh * h", "https://content2.rozetka.com.ua/goods/images/big_tile/310655416.jpg", 692.34m, 4, "Mobile phone Samsung Galaxy S23 Ultra 12/256GB Beige" },
                    { new Guid("c67c49f3-71cf-4a3f-89b0-0056fbcb1107"), new Guid("71a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Your important companions are now even more powerful. Accident detection to get help in an emergency. Stages of sleep to better understand your sleep. As well as new ways to train with the enhanced Workout app. The future of healthcare has never looked so good.", "https://content.rozetka.com.ua/goods/images/big_tile/364852941.jpg", 282.06m, 5, "Apple Watch SE (2023) GPS 40mm Starlight Aluminum Case with Starlight Sport Band - S/M" },
                    { new Guid("d83b8d3d-03f6-4975-b6f4-4b2c7791468d"), new Guid("b1a2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Screen (6.1\", IPS (Liquid Retina HD), 1792x828) / Apple A13 Bionic / main dual camera: 12 MP + 12 MP, front camera: 12 MP / RAM 4 GB / 128 GB built-in memory / 3G / LTE / GPS / GLONASS / Nano-SIM / iOS 13 / 3046 mAh", "https://content.rozetka.com.ua/goods/images/big_tile/37399227.png", 564.14m, 4, "Mobile phone Apple iPhone 11 128GB Black" },
                    { new Guid("f4a17b45-d6f6-4922-80a1-8cb09ac6958c"), new Guid("91a2b3d4-95f6-4d3c-8b7a-6f594d3c2b1a"), "Screen (6.5\", Super AMOLED, 2340x1080) / Mediatek Helio G99 (2 x 2.6 GHz + 6 x 2.0 GHz) / main triple camera: 50 MP + 5 MP + 2 MP, front camera: 13 MP / RAM 6 GB / 128 GB of built-in memory + microSD (up to 1 TB) / 3G / LTE / GPS / GLONASS / BDS / support for 2 SIM cards (Nano-SIM) / Android 13 / 5000 mAh", "https://content.rozetka.com.ua/goods/images/big_tile/328132326.jpg", 194.87m, 3, "Mobile phone Samsung Galaxy A24 6/128GB Black" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ProductId", "Url" },
                values: new object[,]
                {
                    { new Guid("0675d8c8-3053-4176-a4c2-1aa57f0e4c23"), new Guid("6d526229-d129-4b10-b671-949942b64645"), "https://content.rozetka.com.ua/goods/images/big/221214137.jpg" },
                    { new Guid("0a4391d2-92fd-4ebc-8b52-b7a3aec66dda"), new Guid("04c13a1a-2324-4d5c-aa54-20c2a07a0a8b"), "https://content1.rozetka.com.ua/goods/images/big/412885389.jpg" },
                    { new Guid("0df75f54-fe77-4ab2-bcdc-37dd73d93e2b"), new Guid("d83b8d3d-03f6-4975-b6f4-4b2c7791468d"), "https://content1.rozetka.com.ua/goods/images/big/37399245.jpg" },
                    { new Guid("15bd5fae-aadb-4ef2-8f51-206aceb3bf64"), new Guid("c67c49f3-71cf-4a3f-89b0-0056fbcb1107"), "https://content.rozetka.com.ua/goods/images/big/364852941.jpg" },
                    { new Guid("167d55d6-b68a-4ba3-9cc9-5aa96393995b"), new Guid("79a8b7b1-5b5c-4096-bf59-2f5d491949d9"), "https://content1.rozetka.com.ua/goods/images/big/364834253.jpg" },
                    { new Guid("18f9d627-3127-491d-9623-442177c0376b"), new Guid("c67c49f3-71cf-4a3f-89b0-0056fbcb1107"), "https://content2.rozetka.com.ua/goods/images/big/364852943.jpg" },
                    { new Guid("1ae2053f-1da3-4f24-abdb-bbd73a274bcb"), new Guid("3b1b1bb2-655f-4689-8d88-70f9792dc842"), "https://content.rozetka.com.ua/goods/images/big/353760041.jpg" },
                    { new Guid("1d017eb3-1c3f-482a-9d73-5960f47d820b"), new Guid("3b1b1bb2-655f-4689-8d88-70f9792dc842"), "https://content2.rozetka.com.ua/goods/images/big/353760043.jpg" },
                    { new Guid("32192e6f-d487-4fc6-998b-587fd3d566b6"), new Guid("b7df95a3-c2bc-4c3a-91bb-d92776959bd7"), "https://content2.rozetka.com.ua/goods/images/big/310655427.jpg" },
                    { new Guid("4a876fa4-2936-4954-8522-1f556ba8d2d3"), new Guid("f4a17b45-d6f6-4922-80a1-8cb09ac6958c"), "https://content2.rozetka.com.ua/goods/images/big/328132330.jpg" },
                    { new Guid("5c656d28-c364-4e12-a15d-a4ee1ac7b465"), new Guid("79a8b7b1-5b5c-4096-bf59-2f5d491949d9"), "https://content.rozetka.com.ua/goods/images/big/364834255.jpg" },
                    { new Guid("69eaf83f-1281-44f5-89f7-7edddccf7659"), new Guid("04c13a1a-2324-4d5c-aa54-20c2a07a0a8b"), "https://content.rozetka.com.ua/goods/images/big/412885391.jpg" },
                    { new Guid("6aa41a29-1b0a-4079-8909-caeecb0e3f96"), new Guid("d83b8d3d-03f6-4975-b6f4-4b2c7791468d"), "https://content.rozetka.com.ua/goods/images/big/37399230.jpg" },
                    { new Guid("6c8f297c-4c93-46a8-b364-4144a9cf5f57"), new Guid("b7df95a3-c2bc-4c3a-91bb-d92776959bd7"), "https://content.rozetka.com.ua/goods/images/big/310655419.jpg" },
                    { new Guid("8d4623dd-843c-4500-94a2-3486fd823e64"), new Guid("3b1b1bb2-655f-4689-8d88-70f9792dc842"), "https://content.rozetka.com.ua/goods/images/big/353760042.jpg" },
                    { new Guid("930d38be-17dd-40a3-9c01-de9bf4682790"), new Guid("04c13a1a-2324-4d5c-aa54-20c2a07a0a8b"), "https://content1.rozetka.com.ua/goods/images/big/412885394.jpg" },
                    { new Guid("9f0ea046-19b3-4925-9484-b233b22b973d"), new Guid("f4a17b45-d6f6-4922-80a1-8cb09ac6958c"), "https://content1.rozetka.com.ua/goods/images/big/328132333.jpg" },
                    { new Guid("a66b0ce5-3410-4738-ac4d-3d5ea3436e79"), new Guid("6d526229-d129-4b10-b671-949942b64645"), "https://content2.rozetka.com.ua/goods/images/big/221214138.jpg" },
                    { new Guid("b9b2a6d2-49f0-40e0-9068-162ceff10859"), new Guid("b7df95a3-c2bc-4c3a-91bb-d92776959bd7"), "https://content2.rozetka.com.ua/goods/images/big/310655416.jpg" },
                    { new Guid("bb568a43-8627-4547-b692-a4655a3eae5f"), new Guid("6d526229-d129-4b10-b671-949942b64645"), "https://content1.rozetka.com.ua/goods/images/big/221214136.jpg" },
                    { new Guid("c4dd2c0d-426d-423a-93f6-4636ea6267d6"), new Guid("f4a17b45-d6f6-4922-80a1-8cb09ac6958c"), "https://content2.rozetka.com.ua/goods/images/big/328132329.jpg" },
                    { new Guid("ccb7a96e-4d41-41b1-a9ff-2074fbe2ddd3"), new Guid("d83b8d3d-03f6-4975-b6f4-4b2c7791468d"), "https://content1.rozetka.com.ua/goods/images/big/37399239.jpg" },
                    { new Guid("dd1f37d6-a98a-434c-9a4d-194019f05e06"), new Guid("04c13a1a-2324-4d5c-aa54-20c2a07a0a8b"), "https://content2.rozetka.com.ua/goods/images/big/412885396.jpg" },
                    { new Guid("f864c55a-be78-466a-8b0c-168770820b16"), new Guid("79a8b7b1-5b5c-4096-bf59-2f5d491949d9"), "https://content2.rozetka.com.ua/goods/images/big/364834254.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("0071eea5-840f-40fa-b52f-aeabeeb1ada1"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("0675d8c8-3053-4176-a4c2-1aa57f0e4c23"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("09567c32-967d-49a1-852a-e4175fd8426e"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("09a90b9f-6ad2-48a7-9fd7-86e57db2dc35"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("0a4391d2-92fd-4ebc-8b52-b7a3aec66dda"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("0df75f54-fe77-4ab2-bcdc-37dd73d93e2b"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("15bd5fae-aadb-4ef2-8f51-206aceb3bf64"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("167d55d6-b68a-4ba3-9cc9-5aa96393995b"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("18f9d627-3127-491d-9623-442177c0376b"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("1ae2053f-1da3-4f24-abdb-bbd73a274bcb"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("1d017eb3-1c3f-482a-9d73-5960f47d820b"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("32192e6f-d487-4fc6-998b-587fd3d566b6"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("48d8c4e4-d4a6-4cb0-8818-0ecff110782b"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("4a876fa4-2936-4954-8522-1f556ba8d2d3"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("5c656d28-c364-4e12-a15d-a4ee1ac7b465"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("613f38e4-68c3-48d0-bb8f-a4c46ef25022"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("69eaf83f-1281-44f5-89f7-7edddccf7659"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("6aa41a29-1b0a-4079-8909-caeecb0e3f96"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("6c8f297c-4c93-46a8-b364-4144a9cf5f57"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("753b7800-f508-4202-ae39-01469bbd0a8b"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("8d4623dd-843c-4500-94a2-3486fd823e64"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("930d38be-17dd-40a3-9c01-de9bf4682790"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("9f0ea046-19b3-4925-9484-b233b22b973d"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("a4139af2-e9cf-4473-97c5-49b1b8bd5199"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("a66b0ce5-3410-4738-ac4d-3d5ea3436e79"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("add4b8a2-8edd-4905-999a-fc4ef8e52f08"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("b339980d-73fe-4392-93b0-a62f09a7e5dd"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("b6ac62fb-2a15-4715-9aef-8ae24d42be64"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("b9b2a6d2-49f0-40e0-9068-162ceff10859"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("bb568a43-8627-4547-b692-a4655a3eae5f"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("c4dd2c0d-426d-423a-93f6-4636ea6267d6"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("c9d46444-4106-4255-b44c-8ce1391b659c"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("ccb7a96e-4d41-41b1-a9ff-2074fbe2ddd3"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("dd1f37d6-a98a-434c-9a4d-194019f05e06"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("eedafee0-9371-4d97-9766-f25d9ef7b9c7"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("ef20dc91-c7f8-42bc-8e43-0c86a340838a"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("ef60e5c5-78e5-44fa-bac3-3636f00a21c8"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("f864c55a-be78-466a-8b0c-168770820b16"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("fc7d9af0-7947-49fa-8e2d-fda5e0f49d44"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("fe0989ed-1f66-4907-9aad-084e574c7e81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03223da7-6b63-4d52-a84d-2cb9ac560af7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04c13a1a-2324-4d5c-aa54-20c2a07a0a8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("29f11039-71f6-47ab-b498-2cbf9c1c28aa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b1b1bb2-655f-4689-8d88-70f9792dc842"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a3bb2f4-5b89-46c5-9d15-d3d05c4f3886"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d526229-d129-4b10-b671-949942b64645"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79a8b7b1-5b5c-4096-bf59-2f5d491949d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b7df95a3-c2bc-4c3a-91bb-d92776959bd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b9a06fd0-9d17-4901-b998-7b193980f1fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2f34b8c-446d-4917-8d84-b575ca0d5a4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c67c49f3-71cf-4a3f-89b0-0056fbcb1107"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d83b8d3d-03f6-4975-b6f4-4b2c7791468d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4a17b45-d6f6-4922-80a1-8cb09ac6958c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f89271d8-92d4-4d4a-9142-0919908307a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("71a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b41"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b42"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91a2b3d4-95f6-4d3c-8b7a-6f594d3c2b1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1a2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f319f69-85dd-4923-ac9f-5acd0b2a1b39"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91a2b3c4-95f6-4d3c-8b7a-6f594d3c2b1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-95f6-4d3c-8b7a-6f594d3c2b1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f319f69-85dd-4923-ac9f-5acd0b2a1b39"));
        }
    }
}
