using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class OrderItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27a93fea-9a5e-4281-88ca-a680ab38e8d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b6dd73c-a19e-46e3-a773-f55bea902021"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ebdd254-630c-43b1-b66d-746430420f87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40c02982-56a5-4551-9e6d-6bf365f8bf1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4224959d-44cd-428e-b4b7-6ba1dea721c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4acaef9c-69ef-4b58-8d75-f33f3fc9ec41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ad0d1f5-8451-4f29-815a-2240485c48e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5322e5d5-93e2-4d8e-9736-5cc87404c002"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f55820d-fbc7-452f-ad42-b9be5302cae3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7302cb27-9e9b-4676-9598-fa7f4c1b4215"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75780ebb-6b80-414f-aee1-10fd4b342588"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75b40625-d0e7-47cd-9d07-87f2fe677df8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7711858d-fa68-48bc-a05f-886ac88fa9d9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78547d9e-bd28-4572-9dfb-8142eb41d9f0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cb19f49-12b6-44bf-9ff0-f3cb7e4953c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("901f9926-c73d-413a-86b6-1ab8b9b2db54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a12ef6a6-b62a-4584-abfe-dda8fce89e1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aefc7699-746c-4a59-8b18-e8252574dd2c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4fb652e-032e-4a1f-b49d-7edcc8efe9d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b509bb64-6fda-454c-ad6a-08dfd4d607d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0083cba-3d38-4765-90fc-845283aca257"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c30b5388-25c9-4b49-959d-33f7d473ab52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8d1b3a3-407f-4f97-bbf1-c664511b4c6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7f7e488-479d-4392-8a68-a90aaa4b75bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de091249-509c-42d6-89c4-6a9444b9095c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e5093fdb-9b09-4b32-b22d-93772c38dfb3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e6931099-0f21-497b-8865-175ec4340520"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("edd586f9-4f8d-414c-9609-ab3335e43be9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f260f6bb-5e00-4ec0-9490-60a15e063092"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9cad294-0a00-4f84-a813-b95c7140bbe9"));

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShippingFee = table.Column<decimal>(type: "decimal(16,2)", precision: 16, scale: 2, nullable: false),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_ClientId1",
                        column: x => x.ClientId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(16,2)", precision: 16, scale: 2, nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrdersId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "CreatedAt", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("08b6203f-3bb1-4110-8cd7-e882124c6821"), "Sony", "Cameras", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7938), "Sony CyberShot RX10 IV with 0.03 Second Auto-Focus & 25x Optical Zoom", "57415624.jpg", "Sony CyberShot", 999.00m },
                    { new Guid("0ccfb9a2-b6dc-44b5-baf3-c1bd604dfde5"), "Garmin", "Other", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7947), "Garmin Instinct, Rugged Outdoor Watch with GPS, Features Glonass and Galileo", "35640104.jpg", "Garmin Instinct", 79.00m },
                    { new Guid("0eb42362-283b-47e4-8dfe-56b6843f5d48"), "Garmin", "Other", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7941), "Garmin DriveSmart 65, Built-In Voice-Controlled GPS Navigator with 6.95\" High-Res Display , Black", "75241241.jpg", "Garmin DriveSmart", 199.00m },
                    { new Guid("141d6472-cca0-413f-8199-fc3d83ec86bb"), "Dell", "Computers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7849), "Dell 2022 Newest Inspiron 3000 Laptop, 15.6 HD Display, Intel Celeron N4020 Processor, 8GB DDR4 RAM", "63529756.jpg", "Dell Inspiron 3000", 849.00m },
                    { new Guid("1ff3cf5d-ff10-4ef0-8ab5-8d5748b1e38a"), "Lenovo", "Computers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7775), "Lenovo 2022 Newest Ideapad 3 Laptop, 15.6\" HD Touchscreen, 11th Gen Intel Core i3-1115G4 Processor, 8GB DDR4 RAM, 256GB PCIe NVMe SSD", "10744695.jpg", "Lenovo Ideapad", 799.00m },
                    { new Guid("234eeceb-fcea-4435-8426-53125fbb8a1d"), "Samsung", "Phones", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7962), "Samsung Galaxy S5 16GB Black Unlocked", "80522267.jpg", "Samsung Galaxy S5", 299.00m },
                    { new Guid("287e5722-13be-4f59-beb5-2bff0563a8cd"), "Brother", "Printers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7898), "Brother Compact Monochrome Laser Printer, HL-L2350DW, Wireless Printing", "89890247.jpg", "Brother HL-L2350DW", 179.00m },
                    { new Guid("2b2597de-c3fb-43a7-af59-4d4ed36447e0"), "Apple", "Phones", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7953), "Apple iPhone 13 Pro 512Go Graphite - Unlocked and compatible with any carrier of choice on GSM and CDMA networks.", "97815739.jpg", "iPhone 13", 1299.00m },
                    { new Guid("2c5bea69-ad71-42b8-a13d-0bf55ededca2"), "Amazon", "Accessories", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7889), "Amazon Basics Wireless Computer Mouse with USB Nano Receiver - Black", "11677601.jpg", "Wireless Mouse", 39.00m },
                    { new Guid("2d697120-d6fe-43ba-91d4-e28fcc8c4be9"), "Canon", "Printers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7895), "Canon Pixma MG3620 Wireless All-in-One Color Inkjet Printer with Mobile and Tablet Printing, Black", "12643487.jpg", "Canon Pixma MG3620", 99.00m },
                    { new Guid("3887e458-cc01-4332-8693-64ed022a0d46"), "Samsung", "Phones", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7965), "SAMSUNG Galaxy S23 Cell Phone, Factory Unlocked Android Smartphone, 256GB Storage, 50MP Camera, Night Mode, Long Battery Life, Adaptive Display, US Version, 2023, Lavender", "66017605.jpg", "SAMSUNG Galaxy S23", 749.00m },
                    { new Guid("38984865-44ab-4854-b8d1-6ce79dca7379"), "Acer", "Computers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7746), "Acer Swift X SFX14-42G-R607 Creator Laptop | 14\" Full HD 100% sRGB | AMD Ryzen 7 5825U", "84600886.jpg", "Acer Swift", 929.00m },
                    { new Guid("4b1618ed-3a68-45e2-b5f9-434409377dc6"), "HP", "Computers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7874), "HP 2023 15\" HD IPS Laptop, Windows 11, Intel Pentium 4-Core Processor Up to 2.70GHz, 8GB RAM", "92970713.jpg", "HP Pavilion 15", 789.00m },
                    { new Guid("4cac9188-c6cf-493f-afbd-6abe5ef96603"), "Lenovo", "Accessories", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7892), "Lenovo Laptop Shoulder Bag T210, 15.6-Inch Laptop or Tablet", "15587367.jpg", "Laptop Bag T210", 69.00m },
                    { new Guid("6c8ed629-778e-4232-8ddb-5d112fc958e6"), "Nokia", "Phones", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7974), "Nokia G10 | Android 11 | Unlocked Smartphone | 3-Day Battery | Dual SIM | US Version | 3/32GB | 6.52-Inch Screen | 13MP Triple Camera | Dusk", "46411326.jpg", "Nokia G10", 689.00m },
                    { new Guid("7681d19b-18ce-4b49-adce-8124206cf99d"), "Dell", "Computers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7784), "Dell Inspiron 15 3000 Series 3511 Laptop, 15.6\" FHD Touchscreen, Intel Core i5-1035G1, 32GB", "41732775.jpg", "Dell Inspiron 15", 989.00m },
                    { new Guid("7c09454e-3d93-4d45-a94c-5ce977c991de"), "Logitech", "Accessories", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7886), "Logitech MK345 Wireless Combo Full-Sized Keyboard with Palm Rest and Mouse", "83655305.jpg", "Keyboard MK345", 59.00m },
                    { new Guid("83c56dde-acc1-4e4a-930f-c152beb33316"), "MSI", "Computers", new DateTime(2025, 4, 21, 18, 24, 50, 164, DateTimeKind.Local).AddTicks(8952), "MSI Pulse GL66 15.6\" FHD 144Hz Gaming Laptop: Intel Core i7-12700H RTX 3070 16GB 512GB NVMe SSD", "22866337.jpg", "MSI Pulse", 899.00m },
                    { new Guid("86076172-8080-4ab5-a0cc-811d891cd900"), "HP", "Computers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7854), "HP 14\" FHD Laptop for Business and Student, AMD Ryzen3 3250U (Beat i5 7200U), 16GB RAM", "10590390.jpg", "HP ENVY 200", 869.00m },
                    { new Guid("8ff50ca0-ef5a-4520-8841-4810a2898e80"), "Dell", "Computers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7781), "Dell Latitude 7000 7430 14\" Notebook - Full HD - 1920 x 1080 - Intel Core i7 12th Gen i7-1265U Deca-core (10 Core) 1.80 GHz", "81882367.jpg", "Dell Latitude 7000", 1199.00m },
                    { new Guid("9cea55f6-c992-4dbd-818b-d5439cc4c7de"), "Samsung", "Other", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7944), "SAMSUNG Galaxy SmartTag Bluetooth Smart Home Accessory Tracker, Attachment Locator for Lost Keys", "72426380.jpg", "SAMSUNG SmartTag", 89.00m },
                    { new Guid("a28ebb6d-15b2-4fa4-a9b8-05e9473c68f4"), "Kodak", "Cameras", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7931), "KODAK PIXPRO Friendly Zoom FZ55-BL 16MP Digital Camera with 5X Optical Zoom", "65286227.jpg", "KODAK PIXPRO", 299.00m },
                    { new Guid("bf96c2fc-c086-4651-9e0a-b582c7afc058"), "Apple", "Phones", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7950), "Apple iPhone 12, 64GB, Black - Unlocked and compatible with any carrier of choice on GSM and CDMA networks. Tested for battery health and guaranteed to come with a battery that exceeds 90% of original capacity.", "11736965.jpg", "iPhone 12", 969.00m },
                    { new Guid("c11a5664-0c2e-48d5-a464-a1ac1986da68"), "Panasonic", "Cameras", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7908), "Panasonic LUMIX FZ80 4K Digital Camera, 18.1 Megapixel Video Camera, 60X Zoom", "66899970.jpg", "Panasonic LUMIX", 499.00m },
                    { new Guid("c4b5c401-7998-4dfa-9b4e-727feb42bc41"), "Apple", "Phones", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7959), "Apple iPhone 14 Pro 128GB Purple", "57380538.jpg", "iPhone 14", 969.80m },
                    { new Guid("cc463fdb-53df-4f58-b6fe-005e10cd328a"), "Motorola", "Phones", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7971), "Moto G Power | 2022 | 3-Day Battery | Unlocked | Made for US by Motorola | 4/128GB | 50 MP Camera | Ice Blue", "69725864.jpg", "Moto G Power", 699.00m },
                    { new Guid("d401fe1a-cda1-4e29-948f-3e6a02fde903"), "OnePlus", "Phones", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7978), "OnePlus Nord N20 5G | Android Smart Phone | 6.43\" AMOLED Display| 6+128GB | Unlocked | 4500 mAh Battery | 33W Fast Charging | Blue Smoke", "17327675.jpg", "OnePlus Nord N20", 899.00m },
                    { new Guid("dbfb0140-5201-4cc1-8dae-0f7e4ce7fe31"), "Lexmark", "Printers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7901), "Lexmark B3442dw Black and White Laser Printer, Wireless with Ethernet, Mobile-Friendly and Cloud Connection", "91537624.jpg", "Lexmark B3442dw", 319.00m },
                    { new Guid("f22c9273-6ce1-4815-9c2e-7cc8a6603f29"), "Samsung", "Phones", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7968), "SAMSUNG Galaxy Z Flip 3 5G Cell Phone, Factory Unlocked Android Smartphone, 256GB, Flex Mode, Super Steady Camera, Ultra Compact, US Version, Phantom Black", "10967363.jpg", "SAMSUNG Galaxy Z", 899.00m },
                    { new Guid("fd8e0f09-87e8-45b5-b091-4e0e5a189c64"), "HP", "Computers", new DateTime(2025, 4, 21, 18, 24, 50, 166, DateTimeKind.Local).AddTicks(7878), "HP Newest 14\" HD Laptop, Windows 11, Intel Celeron Dual-Core Processor Up to 2.60GHz, 4GB RAM", "16303427.jpg", "HP ENVY 14\"", 779.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrdersId",
                table: "OrderItems",
                column: "OrdersId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId1",
                table: "Orders",
                column: "ClientId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08b6203f-3bb1-4110-8cd7-e882124c6821"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ccfb9a2-b6dc-44b5-baf3-c1bd604dfde5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0eb42362-283b-47e4-8dfe-56b6843f5d48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("141d6472-cca0-413f-8199-fc3d83ec86bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ff3cf5d-ff10-4ef0-8ab5-8d5748b1e38a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("234eeceb-fcea-4435-8426-53125fbb8a1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("287e5722-13be-4f59-beb5-2bff0563a8cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b2597de-c3fb-43a7-af59-4d4ed36447e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c5bea69-ad71-42b8-a13d-0bf55ededca2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d697120-d6fe-43ba-91d4-e28fcc8c4be9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3887e458-cc01-4332-8693-64ed022a0d46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38984865-44ab-4854-b8d1-6ce79dca7379"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b1618ed-3a68-45e2-b5f9-434409377dc6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cac9188-c6cf-493f-afbd-6abe5ef96603"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c8ed629-778e-4232-8ddb-5d112fc958e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7681d19b-18ce-4b49-adce-8124206cf99d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c09454e-3d93-4d45-a94c-5ce977c991de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83c56dde-acc1-4e4a-930f-c152beb33316"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86076172-8080-4ab5-a0cc-811d891cd900"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ff50ca0-ef5a-4520-8841-4810a2898e80"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cea55f6-c992-4dbd-818b-d5439cc4c7de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a28ebb6d-15b2-4fa4-a9b8-05e9473c68f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf96c2fc-c086-4651-9e0a-b582c7afc058"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c11a5664-0c2e-48d5-a464-a1ac1986da68"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c4b5c401-7998-4dfa-9b4e-727feb42bc41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc463fdb-53df-4f58-b6fe-005e10cd328a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d401fe1a-cda1-4e29-948f-3e6a02fde903"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbfb0140-5201-4cc1-8dae-0f7e4ce7fe31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f22c9273-6ce1-4815-9c2e-7cc8a6603f29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fd8e0f09-87e8-45b5-b091-4e0e5a189c64"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "CreatedAt", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("27a93fea-9a5e-4281-88ca-a680ab38e8d1"), "Canon", "Printers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3703), "Canon Pixma MG3620 Wireless All-in-One Color Inkjet Printer with Mobile and Tablet Printing, Black", "12643487.jpg", "Canon Pixma MG3620", 99.00m },
                    { new Guid("2b6dd73c-a19e-46e3-a773-f55bea902021"), "Garmin", "Other", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3746), "Garmin DriveSmart 65, Built-In Voice-Controlled GPS Navigator with 6.95\" High-Res Display , Black", "75241241.jpg", "Garmin DriveSmart", 199.00m },
                    { new Guid("2ebdd254-630c-43b1-b66d-746430420f87"), "Garmin", "Other", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3752), "Garmin Instinct, Rugged Outdoor Watch with GPS, Features Glonass and Galileo", "35640104.jpg", "Garmin Instinct", 79.00m },
                    { new Guid("40c02982-56a5-4551-9e6d-6bf365f8bf1e"), "Apple", "Phones", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3762), "Apple iPhone 13 Pro 512Go Graphite - Unlocked and compatible with any carrier of choice on GSM and CDMA networks.", "97815739.jpg", "iPhone 13", 1299.00m },
                    { new Guid("4224959d-44cd-428e-b4b7-6ba1dea721c2"), "Dell", "Computers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3640), "Dell Inspiron 15 3000 Series 3511 Laptop, 15.6\" FHD Touchscreen, Intel Core i5-1035G1, 32GB", "41732775.jpg", "Dell Inspiron 15", 989.00m },
                    { new Guid("4acaef9c-69ef-4b58-8d75-f33f3fc9ec41"), "Lexmark", "Printers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3713), "Lexmark B3442dw Black and White Laser Printer, Wireless with Ethernet, Mobile-Friendly and Cloud Connection", "91537624.jpg", "Lexmark B3442dw", 319.00m },
                    { new Guid("4ad0d1f5-8451-4f29-815a-2240485c48e7"), "Motorola", "Phones", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3778), "Moto G Power | 2022 | 3-Day Battery | Unlocked | Made for US by Motorola | 4/128GB | 50 MP Camera | Ice Blue", "69725864.jpg", "Moto G Power", 699.00m },
                    { new Guid("5322e5d5-93e2-4d8e-9736-5cc87404c002"), "Apple", "Phones", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3765), "Apple iPhone 14 Pro 128GB Purple", "57380538.jpg", "iPhone 14", 969.80m },
                    { new Guid("5f55820d-fbc7-452f-ad42-b9be5302cae3"), "OnePlus", "Phones", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3787), "OnePlus Nord N20 5G | Android Smart Phone | 6.43\" AMOLED Display| 6+128GB | Unlocked | 4500 mAh Battery | 33W Fast Charging | Blue Smoke", "17327675.jpg", "OnePlus Nord N20", 899.00m },
                    { new Guid("7302cb27-9e9b-4676-9598-fa7f4c1b4215"), "Samsung", "Phones", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3768), "Samsung Galaxy S5 16GB Black Unlocked", "80522267.jpg", "Samsung Galaxy S5", 299.00m },
                    { new Guid("75780ebb-6b80-414f-aee1-10fd4b342588"), "Nokia", "Phones", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3781), "Nokia G10 | Android 11 | Unlocked Smartphone | 3-Day Battery | Dual SIM | US Version | 3/32GB | 6.52-Inch Screen | 13MP Triple Camera | Dusk", "46411326.jpg", "Nokia G10", 689.00m },
                    { new Guid("75b40625-d0e7-47cd-9d07-87f2fe677df8"), "HP", "Computers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3681), "HP 14\" FHD Laptop for Business and Student, AMD Ryzen3 3250U (Beat i5 7200U), 16GB RAM", "10590390.jpg", "HP ENVY 200", 869.00m },
                    { new Guid("7711858d-fa68-48bc-a05f-886ac88fa9d9"), "Lenovo", "Computers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3583), "Lenovo 2022 Newest Ideapad 3 Laptop, 15.6\" HD Touchscreen, 11th Gen Intel Core i3-1115G4 Processor, 8GB DDR4 RAM, 256GB PCIe NVMe SSD", "10744695.jpg", "Lenovo Ideapad", 799.00m },
                    { new Guid("78547d9e-bd28-4572-9dfb-8142eb41d9f0"), "Kodak", "Cameras", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3738), "KODAK PIXPRO Friendly Zoom FZ55-BL 16MP Digital Camera with 5X Optical Zoom", "65286227.jpg", "KODAK PIXPRO", 299.00m },
                    { new Guid("8cb19f49-12b6-44bf-9ff0-f3cb7e4953c6"), "Sony", "Cameras", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3742), "Sony CyberShot RX10 IV with 0.03 Second Auto-Focus & 25x Optical Zoom", "57415624.jpg", "Sony CyberShot", 999.00m },
                    { new Guid("901f9926-c73d-413a-86b6-1ab8b9b2db54"), "Amazon", "Accessories", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3696), "Amazon Basics Wireless Computer Mouse with USB Nano Receiver - Black", "11677601.jpg", "Wireless Mouse", 39.00m },
                    { new Guid("a12ef6a6-b62a-4584-abfe-dda8fce89e1d"), "Samsung", "Other", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3749), "SAMSUNG Galaxy SmartTag Bluetooth Smart Home Accessory Tracker, Attachment Locator for Lost Keys", "72426380.jpg", "SAMSUNG SmartTag", 89.00m },
                    { new Guid("aefc7699-746c-4a59-8b18-e8252574dd2c"), "Samsung", "Phones", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3774), "SAMSUNG Galaxy Z Flip 3 5G Cell Phone, Factory Unlocked Android Smartphone, 256GB, Flex Mode, Super Steady Camera, Ultra Compact, US Version, Phantom Black", "10967363.jpg", "SAMSUNG Galaxy Z", 899.00m },
                    { new Guid("b4fb652e-032e-4a1f-b49d-7edcc8efe9d6"), "Lenovo", "Accessories", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3699), "Lenovo Laptop Shoulder Bag T210, 15.6-Inch Laptop or Tablet", "15587367.jpg", "Laptop Bag T210", 69.00m },
                    { new Guid("b509bb64-6fda-454c-ad6a-08dfd4d607d1"), "HP", "Computers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3688), "HP Newest 14\" HD Laptop, Windows 11, Intel Celeron Dual-Core Processor Up to 2.60GHz, 4GB RAM", "16303427.jpg", "HP ENVY 14\"", 779.00m },
                    { new Guid("c0083cba-3d38-4765-90fc-845283aca257"), "Acer", "Computers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3558), "Acer Swift X SFX14-42G-R607 Creator Laptop | 14\" Full HD 100% sRGB | AMD Ryzen 7 5825U", "84600886.jpg", "Acer Swift", 929.00m },
                    { new Guid("c30b5388-25c9-4b49-959d-33f7d473ab52"), "HP", "Computers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3685), "HP 2023 15\" HD IPS Laptop, Windows 11, Intel Pentium 4-Core Processor Up to 2.70GHz, 8GB RAM", "92970713.jpg", "HP Pavilion 15", 789.00m },
                    { new Guid("c8d1b3a3-407f-4f97-bbf1-c664511b4c6e"), "Dell", "Computers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3635), "Dell Latitude 7000 7430 14\" Notebook - Full HD - 1920 x 1080 - Intel Core i7 12th Gen i7-1265U Deca-core (10 Core) 1.80 GHz", "81882367.jpg", "Dell Latitude 7000", 1199.00m },
                    { new Guid("d7f7e488-479d-4392-8a68-a90aaa4b75bd"), "Dell", "Computers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3678), "Dell 2022 Newest Inspiron 3000 Laptop, 15.6 HD Display, Intel Celeron N4020 Processor, 8GB DDR4 RAM", "63529756.jpg", "Dell Inspiron 3000", 849.00m },
                    { new Guid("de091249-509c-42d6-89c4-6a9444b9095c"), "Brother", "Printers", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3709), "Brother Compact Monochrome Laser Printer, HL-L2350DW, Wireless Printing", "89890247.jpg", "Brother HL-L2350DW", 179.00m },
                    { new Guid("e5093fdb-9b09-4b32-b22d-93772c38dfb3"), "Logitech", "Accessories", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3693), "Logitech MK345 Wireless Combo Full-Sized Keyboard with Palm Rest and Mouse", "83655305.jpg", "Keyboard MK345", 59.00m },
                    { new Guid("e6931099-0f21-497b-8865-175ec4340520"), "Samsung", "Phones", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3771), "SAMSUNG Galaxy S23 Cell Phone, Factory Unlocked Android Smartphone, 256GB Storage, 50MP Camera, Night Mode, Long Battery Life, Adaptive Display, US Version, 2023, Lavender", "66017605.jpg", "SAMSUNG Galaxy S23", 749.00m },
                    { new Guid("edd586f9-4f8d-414c-9609-ab3335e43be9"), "MSI", "Computers", new DateTime(2025, 4, 21, 18, 20, 43, 887, DateTimeKind.Local).AddTicks(5654), "MSI Pulse GL66 15.6\" FHD 144Hz Gaming Laptop: Intel Core i7-12700H RTX 3070 16GB 512GB NVMe SSD", "22866337.jpg", "MSI Pulse", 899.00m },
                    { new Guid("f260f6bb-5e00-4ec0-9490-60a15e063092"), "Panasonic", "Cameras", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3734), "Panasonic LUMIX FZ80 4K Digital Camera, 18.1 Megapixel Video Camera, 60X Zoom", "66899970.jpg", "Panasonic LUMIX", 499.00m },
                    { new Guid("f9cad294-0a00-4f84-a813-b95c7140bbe9"), "Apple", "Phones", new DateTime(2025, 4, 21, 18, 20, 43, 889, DateTimeKind.Local).AddTicks(3759), "Apple iPhone 12, 64GB, Black - Unlocked and compatible with any carrier of choice on GSM and CDMA networks. Tested for battery health and guaranteed to come with a battery that exceeds 90% of original capacity.", "11736965.jpg", "iPhone 12", 969.00m }
                });
        }
    }
}
