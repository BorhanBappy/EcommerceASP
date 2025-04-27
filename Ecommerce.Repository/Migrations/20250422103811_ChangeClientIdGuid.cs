using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class ChangeClientIdGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ClientId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientId1",
                table: "Orders");

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

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Orders");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "CreatedAt", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("10a6495a-d798-4881-8a1c-c32b644d7a1d"), "Logitech", "Accessories", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5515), "Logitech MK345 Wireless Combo Full-Sized Keyboard with Palm Rest and Mouse", "83655305.jpg", "Keyboard MK345", 59.00m },
                    { new Guid("127fe090-b4fa-4ddc-87e1-1ac68ecac3b3"), "HP", "Computers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5493), "HP 14\" FHD Laptop for Business and Student, AMD Ryzen3 3250U (Beat i5 7200U), 16GB RAM", "10590390.jpg", "HP ENVY 200", 869.00m },
                    { new Guid("177b2438-178e-40a5-92c5-12e680ed1e88"), "OnePlus", "Phones", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5708), "OnePlus Nord N20 5G | Android Smart Phone | 6.43\" AMOLED Display| 6+128GB | Unlocked | 4500 mAh Battery | 33W Fast Charging | Blue Smoke", "17327675.jpg", "OnePlus Nord N20", 899.00m },
                    { new Guid("1bade792-9c50-4164-a2e5-b851f3d2336e"), "Canon", "Printers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5589), "Canon Pixma MG3620 Wireless All-in-One Color Inkjet Printer with Mobile and Tablet Printing, Black", "12643487.jpg", "Canon Pixma MG3620", 99.00m },
                    { new Guid("1df60045-1746-4369-a504-8fe7050841c2"), "Samsung", "Phones", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5675), "Samsung Galaxy S5 16GB Black Unlocked", "80522267.jpg", "Samsung Galaxy S5", 299.00m },
                    { new Guid("24a68e06-efef-4d93-a0f6-a2f8902af059"), "Garmin", "Other", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5627), "Garmin DriveSmart 65, Built-In Voice-Controlled GPS Navigator with 6.95\" High-Res Display , Black", "75241241.jpg", "Garmin DriveSmart", 199.00m },
                    { new Guid("2928e7d6-3fc6-47f5-9d38-d73f03cf22e0"), "Samsung", "Other", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5632), "SAMSUNG Galaxy SmartTag Bluetooth Smart Home Accessory Tracker, Attachment Locator for Lost Keys", "72426380.jpg", "SAMSUNG SmartTag", 89.00m },
                    { new Guid("2b8b21a1-3abc-48d6-ba5d-93d18a891110"), "Dell", "Computers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5465), "Dell Inspiron 15 3000 Series 3511 Laptop, 15.6\" FHD Touchscreen, Intel Core i5-1035G1, 32GB", "41732775.jpg", "Dell Inspiron 15", 989.00m },
                    { new Guid("3035ec77-44dd-414b-9ecc-08a10d98bb51"), "MSI", "Computers", new DateTime(2025, 4, 22, 16, 38, 6, 187, DateTimeKind.Local).AddTicks(6731), "MSI Pulse GL66 15.6\" FHD 144Hz Gaming Laptop: Intel Core i7-12700H RTX 3070 16GB 512GB NVMe SSD", "22866337.jpg", "MSI Pulse", 899.00m },
                    { new Guid("32485c24-bfb1-4935-880d-2b656fc1f051"), "Sony", "Cameras", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5622), "Sony CyberShot RX10 IV with 0.03 Second Auto-Focus & 25x Optical Zoom", "57415624.jpg", "Sony CyberShot", 999.00m },
                    { new Guid("416eb64c-9ec5-486d-9c25-c47b0d4af2f5"), "HP", "Computers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5499), "HP 2023 15\" HD IPS Laptop, Windows 11, Intel Pentium 4-Core Processor Up to 2.70GHz, 8GB RAM", "92970713.jpg", "HP Pavilion 15", 789.00m },
                    { new Guid("455e1a8f-3898-4b9e-b2da-58260eb0b67b"), "Lenovo", "Accessories", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5576), "Lenovo Laptop Shoulder Bag T210, 15.6-Inch Laptop or Tablet", "15587367.jpg", "Laptop Bag T210", 69.00m },
                    { new Guid("467c4180-94c4-44e5-a9ba-03d514fd6c6c"), "Panasonic", "Cameras", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5606), "Panasonic LUMIX FZ80 4K Digital Camera, 18.1 Megapixel Video Camera, 60X Zoom", "66899970.jpg", "Panasonic LUMIX", 499.00m },
                    { new Guid("4bca63ad-a189-4141-8de0-d2230781f1d5"), "Dell", "Computers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5435), "Dell Latitude 7000 7430 14\" Notebook - Full HD - 1920 x 1080 - Intel Core i7 12th Gen i7-1265U Deca-core (10 Core) 1.80 GHz", "81882367.jpg", "Dell Latitude 7000", 1199.00m },
                    { new Guid("4f08c492-1989-4c4e-a96f-59d901252624"), "Garmin", "Other", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5643), "Garmin Instinct, Rugged Outdoor Watch with GPS, Features Glonass and Galileo", "35640104.jpg", "Garmin Instinct", 79.00m },
                    { new Guid("5145675b-baaf-4074-8599-a0f67feba7df"), "Amazon", "Accessories", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5568), "Amazon Basics Wireless Computer Mouse with USB Nano Receiver - Black", "11677601.jpg", "Wireless Mouse", 39.00m },
                    { new Guid("659a31ce-60f7-444c-99aa-de29297ca7d1"), "Kodak", "Cameras", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5612), "KODAK PIXPRO Friendly Zoom FZ55-BL 16MP Digital Camera with 5X Optical Zoom", "65286227.jpg", "KODAK PIXPRO", 299.00m },
                    { new Guid("69af4059-050f-454c-90e0-ed9608388ecb"), "HP", "Computers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5505), "HP Newest 14\" HD Laptop, Windows 11, Intel Celeron Dual-Core Processor Up to 2.60GHz, 4GB RAM", "16303427.jpg", "HP ENVY 14\"", 779.00m },
                    { new Guid("73c66dc3-86fe-4988-b4b4-8dd9651f5e3f"), "Motorola", "Phones", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5692), "Moto G Power | 2022 | 3-Day Battery | Unlocked | Made for US by Motorola | 4/128GB | 50 MP Camera | Ice Blue", "69725864.jpg", "Moto G Power", 699.00m },
                    { new Guid("7881fdb9-f6da-4d06-b97c-96348f21d0bd"), "Apple", "Phones", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5657), "Apple iPhone 13 Pro 512Go Graphite - Unlocked and compatible with any carrier of choice on GSM and CDMA networks.", "97815739.jpg", "iPhone 13", 1299.00m },
                    { new Guid("8a08c409-0348-4f78-b6c4-75724452623f"), "Nokia", "Phones", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5702), "Nokia G10 | Android 11 | Unlocked Smartphone | 3-Day Battery | Dual SIM | US Version | 3/32GB | 6.52-Inch Screen | 13MP Triple Camera | Dusk", "46411326.jpg", "Nokia G10", 689.00m },
                    { new Guid("8e158843-52be-4ca4-8081-35e612e20ace"), "Apple", "Phones", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5669), "Apple iPhone 14 Pro 128GB Purple", "57380538.jpg", "iPhone 14", 969.80m },
                    { new Guid("969a2406-bf57-4a46-9820-f4d4dc892afe"), "Apple", "Phones", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5649), "Apple iPhone 12, 64GB, Black - Unlocked and compatible with any carrier of choice on GSM and CDMA networks. Tested for battery health and guaranteed to come with a battery that exceeds 90% of original capacity.", "11736965.jpg", "iPhone 12", 969.00m },
                    { new Guid("a8329993-e6d8-4962-b348-643dba15d013"), "Samsung", "Phones", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5686), "SAMSUNG Galaxy Z Flip 3 5G Cell Phone, Factory Unlocked Android Smartphone, 256GB, Flex Mode, Super Steady Camera, Ultra Compact, US Version, Phantom Black", "10967363.jpg", "SAMSUNG Galaxy Z", 899.00m },
                    { new Guid("b75b5318-33de-4d70-9098-cf792e7c39fe"), "Acer", "Computers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5390), "Acer Swift X SFX14-42G-R607 Creator Laptop | 14\" Full HD 100% sRGB | AMD Ryzen 7 5825U", "84600886.jpg", "Acer Swift", 929.00m },
                    { new Guid("b8ad36f5-7d08-4b1a-8a54-95a359064acb"), "Samsung", "Phones", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5680), "SAMSUNG Galaxy S23 Cell Phone, Factory Unlocked Android Smartphone, 256GB Storage, 50MP Camera, Night Mode, Long Battery Life, Adaptive Display, US Version, 2023, Lavender", "66017605.jpg", "SAMSUNG Galaxy S23", 749.00m },
                    { new Guid("bcfa15f3-2a86-4ce6-97df-2d804e0c6a32"), "Lenovo", "Computers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5429), "Lenovo 2022 Newest Ideapad 3 Laptop, 15.6\" HD Touchscreen, 11th Gen Intel Core i3-1115G4 Processor, 8GB DDR4 RAM, 256GB PCIe NVMe SSD", "10744695.jpg", "Lenovo Ideapad", 799.00m },
                    { new Guid("c7221f74-b6b9-4082-8bce-f58f4853087e"), "Lexmark", "Printers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5601), "Lexmark B3442dw Black and White Laser Printer, Wireless with Ethernet, Mobile-Friendly and Cloud Connection", "91537624.jpg", "Lexmark B3442dw", 319.00m },
                    { new Guid("cf5226c9-6bb1-4043-93f9-3f9170bbe112"), "Brother", "Printers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5595), "Brother Compact Monochrome Laser Printer, HL-L2350DW, Wireless Printing", "89890247.jpg", "Brother HL-L2350DW", 179.00m },
                    { new Guid("d62a6cb9-977b-48ca-86bd-347e0cd4d3eb"), "Dell", "Computers", new DateTime(2025, 4, 22, 16, 38, 6, 190, DateTimeKind.Local).AddTicks(5487), "Dell 2022 Newest Inspiron 3000 Laptop, 15.6 HD Display, Intel Celeron N4020 Processor, 8GB DDR4 RAM", "63529756.jpg", "Dell Inspiron 3000", 849.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_ClientId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ClientId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10a6495a-d798-4881-8a1c-c32b644d7a1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("127fe090-b4fa-4ddc-87e1-1ac68ecac3b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("177b2438-178e-40a5-92c5-12e680ed1e88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1bade792-9c50-4164-a2e5-b851f3d2336e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1df60045-1746-4369-a504-8fe7050841c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24a68e06-efef-4d93-a0f6-a2f8902af059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2928e7d6-3fc6-47f5-9d38-d73f03cf22e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b8b21a1-3abc-48d6-ba5d-93d18a891110"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3035ec77-44dd-414b-9ecc-08a10d98bb51"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("32485c24-bfb1-4935-880d-2b656fc1f051"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("416eb64c-9ec5-486d-9c25-c47b0d4af2f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("455e1a8f-3898-4b9e-b2da-58260eb0b67b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("467c4180-94c4-44e5-a9ba-03d514fd6c6c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bca63ad-a189-4141-8de0-d2230781f1d5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4f08c492-1989-4c4e-a96f-59d901252624"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5145675b-baaf-4074-8599-a0f67feba7df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("659a31ce-60f7-444c-99aa-de29297ca7d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69af4059-050f-454c-90e0-ed9608388ecb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73c66dc3-86fe-4988-b4b4-8dd9651f5e3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7881fdb9-f6da-4d06-b97c-96348f21d0bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a08c409-0348-4f78-b6c4-75724452623f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e158843-52be-4ca4-8081-35e612e20ace"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("969a2406-bf57-4a46-9820-f4d4dc892afe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8329993-e6d8-4962-b348-643dba15d013"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b75b5318-33de-4d70-9098-cf792e7c39fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8ad36f5-7d08-4b1a-8a54-95a359064acb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcfa15f3-2a86-4ce6-97df-2d804e0c6a32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c7221f74-b6b9-4082-8bce-f58f4853087e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cf5226c9-6bb1-4043-93f9-3f9170bbe112"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d62a6cb9-977b-48ca-86bd-347e0cd4d3eb"));

            migrationBuilder.AlterColumn<string>(
                name: "ClientId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId1",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "IX_Orders_ClientId1",
                table: "Orders",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_ClientId1",
                table: "Orders",
                column: "ClientId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
