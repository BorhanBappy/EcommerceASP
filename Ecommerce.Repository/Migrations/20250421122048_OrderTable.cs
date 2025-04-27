using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Migrations
{
    /// <inheritdoc />
    public partial class OrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08f63191-c2fa-4145-8aff-5b81f1e32abd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0eaf1863-55dc-4602-acae-eb9d22dc7572"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f991b3f-20ef-446d-93a8-7d492192ad17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21319bb6-f618-4aec-ad65-3005f6d6737b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("234e3f40-4541-43e9-ab47-4483a68146d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("277a2d37-d8e6-4e2a-bbe7-691ba7f17945"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2aa4edfc-3e2f-4601-9b3e-b0b4597f8b7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b93af2c-1203-489f-a870-260a41224c9a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3aadbaf3-df11-4265-8c69-7a14dac8d8ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d78bfe3-5cee-44c0-8fad-d2a3a32a6080"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42e8b01f-4a6e-498a-84b8-a0e063de703d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("485d2638-9660-4f18-b94f-4ab04f3ea47d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50dc0bc2-997d-414e-993f-8bb6be9f52c0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("78d292e2-a6c1-423d-be74-a1ebb51527de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86da0e95-de89-4934-b4d1-2a8396b83999"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("937f292d-9fc1-40fb-9f24-4ecea084087c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a67c1028-bee1-4b08-8a7d-0af9ebe36f81"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a69297a7-70fe-4632-9119-acccb13b210f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abfa02db-2f64-4274-862f-d8ea91987669"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3a57173-1cd6-412d-b1a7-5b04a8d782ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b897602a-8929-4e5d-b5e5-4662195f233a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c183af94-ee64-435a-ad74-81cb1107dd41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb418017-34a1-4373-a4c6-7d12655bf01a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb84f9ee-b8e4-4fb1-9b17-65469df73393"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea1be25e-0bd4-4a14-80f7-bac7dc6a251e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ec9303bd-4753-4663-ae3d-2838e29b7f15"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("edf17ed3-8f12-4872-a8e4-473b29c15a23"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9339c36-b56a-47b1-9d5e-753a92c45e4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe90d82a-bdbf-4ddf-b5b3-a25fc3c3bf33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fed29a95-6f8f-4832-bdb9-0c3f4e8eebcf"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
