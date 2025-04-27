using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(16,2)", precision: 16, scale: 2, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "CreatedAt", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("08f63191-c2fa-4145-8aff-5b81f1e32abd"), "Motorola", "Phones", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5980), "Moto G Power | 2022 | 3-Day Battery | Unlocked | Made for US by Motorola | 4/128GB | 50 MP Camera | Ice Blue", "69725864.jpg", "Moto G Power", 699.00m },
                    { new Guid("0eaf1863-55dc-4602-acae-eb9d22dc7572"), "HP", "Computers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5807), "HP 14\" FHD Laptop for Business and Student, AMD Ryzen3 3250U (Beat i5 7200U), 16GB RAM", "10590390.jpg", "HP ENVY 200", 869.00m },
                    { new Guid("0f991b3f-20ef-446d-93a8-7d492192ad17"), "Samsung", "Phones", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5969), "Samsung Galaxy S5 16GB Black Unlocked", "80522267.jpg", "Samsung Galaxy S5", 299.00m },
                    { new Guid("21319bb6-f618-4aec-ad65-3005f6d6737b"), "Amazon", "Accessories", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5903), "Amazon Basics Wireless Computer Mouse with USB Nano Receiver - Black", "11677601.jpg", "Wireless Mouse", 39.00m },
                    { new Guid("234e3f40-4541-43e9-ab47-4483a68146d0"), "Apple", "Phones", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5962), "Apple iPhone 14 Pro 128GB Purple", "57380538.jpg", "iPhone 14", 969.80m },
                    { new Guid("277a2d37-d8e6-4e2a-bbe7-691ba7f17945"), "HP", "Computers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5831), "HP Newest 14\" HD Laptop, Windows 11, Intel Celeron Dual-Core Processor Up to 2.60GHz, 4GB RAM", "16303427.jpg", "HP ENVY 14\"", 779.00m },
                    { new Guid("2aa4edfc-3e2f-4601-9b3e-b0b4597f8b7f"), "Lenovo", "Computers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5778), "Lenovo 2022 Newest Ideapad 3 Laptop, 15.6\" HD Touchscreen, 11th Gen Intel Core i3-1115G4 Processor, 8GB DDR4 RAM, 256GB PCIe NVMe SSD", "10744695.jpg", "Lenovo Ideapad", 799.00m },
                    { new Guid("2b93af2c-1203-489f-a870-260a41224c9a"), "Kodak", "Cameras", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5933), "KODAK PIXPRO Friendly Zoom FZ55-BL 16MP Digital Camera with 5X Optical Zoom", "65286227.jpg", "KODAK PIXPRO", 299.00m },
                    { new Guid("3aadbaf3-df11-4265-8c69-7a14dac8d8ed"), "Apple", "Phones", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5958), "Apple iPhone 13 Pro 512Go Graphite - Unlocked and compatible with any carrier of choice on GSM and CDMA networks.", "97815739.jpg", "iPhone 13", 1299.00m },
                    { new Guid("3d78bfe3-5cee-44c0-8fad-d2a3a32a6080"), "MSI", "Computers", new DateTime(2025, 4, 18, 11, 26, 3, 299, DateTimeKind.Local).AddTicks(6148), "MSI Pulse GL66 15.6\" FHD 144Hz Gaming Laptop: Intel Core i7-12700H RTX 3070 16GB 512GB NVMe SSD", "22866337.jpg", "MSI Pulse", 899.00m },
                    { new Guid("42e8b01f-4a6e-498a-84b8-a0e063de703d"), "Logitech", "Accessories", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5838), "Logitech MK345 Wireless Combo Full-Sized Keyboard with Palm Rest and Mouse", "83655305.jpg", "Keyboard MK345", 59.00m },
                    { new Guid("485d2638-9660-4f18-b94f-4ab04f3ea47d"), "Dell", "Computers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5786), "Dell Inspiron 15 3000 Series 3511 Laptop, 15.6\" FHD Touchscreen, Intel Core i5-1035G1, 32GB", "41732775.jpg", "Dell Inspiron 15", 989.00m },
                    { new Guid("50dc0bc2-997d-414e-993f-8bb6be9f52c0"), "Nokia", "Phones", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5984), "Nokia G10 | Android 11 | Unlocked Smartphone | 3-Day Battery | Dual SIM | US Version | 3/32GB | 6.52-Inch Screen | 13MP Triple Camera | Dusk", "46411326.jpg", "Nokia G10", 689.00m },
                    { new Guid("78d292e2-a6c1-423d-be74-a1ebb51527de"), "Lenovo", "Accessories", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5910), "Lenovo Laptop Shoulder Bag T210, 15.6-Inch Laptop or Tablet", "15587367.jpg", "Laptop Bag T210", 69.00m },
                    { new Guid("86da0e95-de89-4934-b4d1-2a8396b83999"), "Lexmark", "Printers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5921), "Lexmark B3442dw Black and White Laser Printer, Wireless with Ethernet, Mobile-Friendly and Cloud Connection", "91537624.jpg", "Lexmark B3442dw", 319.00m },
                    { new Guid("937f292d-9fc1-40fb-9f24-4ecea084087c"), "Sony", "Cameras", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5939), "Sony CyberShot RX10 IV with 0.03 Second Auto-Focus & 25x Optical Zoom", "57415624.jpg", "Sony CyberShot", 999.00m },
                    { new Guid("a67c1028-bee1-4b08-8a7d-0af9ebe36f81"), "Samsung", "Phones", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5976), "SAMSUNG Galaxy Z Flip 3 5G Cell Phone, Factory Unlocked Android Smartphone, 256GB, Flex Mode, Super Steady Camera, Ultra Compact, US Version, Phantom Black", "10967363.jpg", "SAMSUNG Galaxy Z", 899.00m },
                    { new Guid("a69297a7-70fe-4632-9119-acccb13b210f"), "Dell", "Computers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5803), "Dell 2022 Newest Inspiron 3000 Laptop, 15.6 HD Display, Intel Celeron N4020 Processor, 8GB DDR4 RAM", "63529756.jpg", "Dell Inspiron 3000", 849.00m },
                    { new Guid("abfa02db-2f64-4274-862f-d8ea91987669"), "Apple", "Phones", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5954), "Apple iPhone 12, 64GB, Black - Unlocked and compatible with any carrier of choice on GSM and CDMA networks. Tested for battery health and guaranteed to come with a battery that exceeds 90% of original capacity.", "11736965.jpg", "iPhone 12", 969.00m },
                    { new Guid("b3a57173-1cd6-412d-b1a7-5b04a8d782ac"), "Acer", "Computers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5751), "Acer Swift X SFX14-42G-R607 Creator Laptop | 14\" Full HD 100% sRGB | AMD Ryzen 7 5825U", "84600886.jpg", "Acer Swift", 929.00m },
                    { new Guid("b897602a-8929-4e5d-b5e5-4662195f233a"), "Canon", "Printers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5913), "Canon Pixma MG3620 Wireless All-in-One Color Inkjet Printer with Mobile and Tablet Printing, Black", "12643487.jpg", "Canon Pixma MG3620", 99.00m },
                    { new Guid("c183af94-ee64-435a-ad74-81cb1107dd41"), "Garmin", "Other", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5942), "Garmin DriveSmart 65, Built-In Voice-Controlled GPS Navigator with 6.95\" High-Res Display , Black", "75241241.jpg", "Garmin DriveSmart", 199.00m },
                    { new Guid("cb418017-34a1-4373-a4c6-7d12655bf01a"), "Samsung", "Other", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5946), "SAMSUNG Galaxy SmartTag Bluetooth Smart Home Accessory Tracker, Attachment Locator for Lost Keys", "72426380.jpg", "SAMSUNG SmartTag", 89.00m },
                    { new Guid("cb84f9ee-b8e4-4fb1-9b17-65469df73393"), "Dell", "Computers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5782), "Dell Latitude 7000 7430 14\" Notebook - Full HD - 1920 x 1080 - Intel Core i7 12th Gen i7-1265U Deca-core (10 Core) 1.80 GHz", "81882367.jpg", "Dell Latitude 7000", 1199.00m },
                    { new Guid("ea1be25e-0bd4-4a14-80f7-bac7dc6a251e"), "OnePlus", "Phones", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5987), "OnePlus Nord N20 5G | Android Smart Phone | 6.43\" AMOLED Display| 6+128GB | Unlocked | 4500 mAh Battery | 33W Fast Charging | Blue Smoke", "17327675.jpg", "OnePlus Nord N20", 899.00m },
                    { new Guid("ec9303bd-4753-4663-ae3d-2838e29b7f15"), "Brother", "Printers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5917), "Brother Compact Monochrome Laser Printer, HL-L2350DW, Wireless Printing", "89890247.jpg", "Brother HL-L2350DW", 179.00m },
                    { new Guid("edf17ed3-8f12-4872-a8e4-473b29c15a23"), "HP", "Computers", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5811), "HP 2023 15\" HD IPS Laptop, Windows 11, Intel Pentium 4-Core Processor Up to 2.70GHz, 8GB RAM", "92970713.jpg", "HP Pavilion 15", 789.00m },
                    { new Guid("f9339c36-b56a-47b1-9d5e-753a92c45e4d"), "Garmin", "Other", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5950), "Garmin Instinct, Rugged Outdoor Watch with GPS, Features Glonass and Galileo", "35640104.jpg", "Garmin Instinct", 79.00m },
                    { new Guid("fe90d82a-bdbf-4ddf-b5b3-a25fc3c3bf33"), "Samsung", "Phones", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5973), "SAMSUNG Galaxy S23 Cell Phone, Factory Unlocked Android Smartphone, 256GB Storage, 50MP Camera, Night Mode, Long Battery Life, Adaptive Display, US Version, 2023, Lavender", "66017605.jpg", "SAMSUNG Galaxy S23", 749.00m },
                    { new Guid("fed29a95-6f8f-4832-bdb9-0c3f4e8eebcf"), "Panasonic", "Cameras", new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5924), "Panasonic LUMIX FZ80 4K Digital Camera, 18.1 Megapixel Video Camera, 60X Zoom", "66899970.jpg", "Panasonic LUMIX", 499.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
