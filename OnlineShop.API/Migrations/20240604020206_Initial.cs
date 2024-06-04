using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineShop.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShippingAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockQuantity = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_ShippingAddresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "ShippingAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<long>(type: "bigint", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("946a0305-470a-461a-87e3-8fd62c6dc115"), "Електроніка" },
                    { new Guid("96ccf359-94b9-4fad-a857-6fd2e4c6519f"), "Спорт та відпочинок" },
                    { new Guid("a7a0b109-23ec-4af2-ad2c-4149a5888082"), "Книги" }
                });

            migrationBuilder.InsertData(
                table: "ShippingAddresses",
                columns: new[] { "Id", "City", "Country", "HouseNumber", "OrderId", "Street" },
                values: new object[,]
                {
                    { new Guid("1c869fa4-7e41-4ef7-863f-d8cbdbdae30b"), "Київ", "Україна", 11L, new Guid("92daa1c6-86f9-43b6-9064-aa2b4c9958a8"), "Хрещатик" },
                    { new Guid("7128b902-4778-4a3d-975b-ab9c62e8a0c4"), "Кропивницький", "Україна", 8L, new Guid("d8c7bd81-a34c-4677-b698-dadac6708b84"), "Соборна" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerEmail", "CustomerName", "OrderDate", "ShippingAddressId" },
                values: new object[,]
                {
                    { new Guid("92daa1c6-86f9-43b6-9064-aa2b4c9958a8"), "olexander@gmail.com", "Olexander", new DateTime(2024, 6, 4, 5, 2, 4, 932, DateTimeKind.Local).AddTicks(8414), new Guid("1c869fa4-7e41-4ef7-863f-d8cbdbdae30b") },
                    { new Guid("d8c7bd81-a34c-4677-b698-dadac6708b84"), "serhii@gmail.com", "Serhii", new DateTime(2024, 6, 4, 5, 2, 4, 932, DateTimeKind.Local).AddTicks(9091), new Guid("7128b902-4778-4a3d-975b-ab9c62e8a0c4") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("16cdd060-3e1f-459e-9d5c-c69374dea2f8"), new Guid("946a0305-470a-461a-87e3-8fd62c6dc115"), "Екран 16 IPS (1920x1200) WUXGA, матовий / AMD Ryzen 7 7730U (2.0 - 4.5 ГГц) / RAM 16 ГБ / SSD 512 ГБ / AMD Radeon Graphics / без ОД / Wi-Fi / Bluetooth / веб-камера / без ОС / 1.74 кг / сірий", "https://content.rozetka.com.ua/goods/images/big/334493611.jpg", "Ноутбук Lenovo IdeaPad Slim 3 16ABR8", 24530m, 10L },
                    { new Guid("89cbcc94-afe6-4b6f-b959-c1dcf82b1e6a"), new Guid("946a0305-470a-461a-87e3-8fd62c6dc115"), "Екран 15.6 IPS (1920x1080) Full HD, матовий / Intel Core i5-12450H (2.0 - 4.4 ГГц) / RAM 32 ГБ / SSD 512 ГБ / Intel Iris Xe Graphics / без ОД / LAN / Wi-Fi / Bluetooth / вебкамера / без ОС / 1.76 кг / сірий", "https://content1.rozetka.com.ua/goods/images/big/357248068.jpg", "Ноутбук Acer Aspire 5 A515-57-59NG", 26777m, 15L },
                    { new Guid("95449600-d1eb-4377-b9fc-9dd70c0e4c50"), new Guid("a7a0b109-23ec-4af2-ad2c-4149a5888082"), "Року Божого 1521 папа Лев Х видав буллу, в якій було сказано, що Рим ніколи не повинен залишатися в темряві. П’ять століть по тому негода призвела до збоїв у роботі однієї з електростанцій. Щоб усунути пошкодження, постачання електроенергії довелося відключити на добу. І Рим поглинула темрява, пробудивши зло.", "https://content2.rozetka.com.ua/goods/images/big/335210773.jpg", "Володар тіні - К. Донато", 240m, 3L },
                    { new Guid("bfeb5b61-d188-4074-8640-0fc5f24be7b3"), new Guid("a7a0b109-23ec-4af2-ad2c-4149a5888082"), "Приготуйтеся до шторму, що сколихне увесь світ «Якщо все піде так, як я планував, то через тиждень, 30 серпня 2020 року, світ на хвилину затамує подих. На різних континентах відбуватимуться певні події, на перший погляд, ніяк не пов'язані. Тільки той, хто придивиться до них уважніше, зрозуміє, що насправді це фрагменти однієї й тієї ж історії».", "https://content2.rozetka.com.ua/goods/images/big/354966480.jpg", "Ідеальний шторм - Д. Райнгардт", 450.5m, 5L },
                    { new Guid("cb1a499b-a1b6-4e94-95c9-d1dc4653f3a1"), new Guid("96ccf359-94b9-4fad-a857-6fd2e4c6519f"), "Мішок боксерський SportKo Бочонок PVC з кільцем 75 см черний - ідеальний варіант для домашнього використання.", "https://content1.rozetka.com.ua/goods/images/big/220901139.png", "Мішок боксерський Sportko Бочечка", 1175m, 7L }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("09299418-34de-47c4-bdb7-a1f4725e6a42"), new Guid("92daa1c6-86f9-43b6-9064-aa2b4c9958a8"), new Guid("95449600-d1eb-4377-b9fc-9dd70c0e4c50"), 1L },
                    { new Guid("51841a8b-5ba6-422f-a24f-ea1b36e9ee90"), new Guid("92daa1c6-86f9-43b6-9064-aa2b4c9958a8"), new Guid("bfeb5b61-d188-4074-8640-0fc5f24be7b3"), 1L },
                    { new Guid("7a729c57-6a52-49bd-8418-a4a55362d3e7"), new Guid("d8c7bd81-a34c-4677-b698-dadac6708b84"), new Guid("cb1a499b-a1b6-4e94-95c9-d1dc4653f3a1"), 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressId",
                table: "Orders",
                column: "ShippingAddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShippingAddresses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
