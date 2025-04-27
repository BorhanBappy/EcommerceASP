
using Ecommerce.Entity.Models;

namespace Ecommerce.Repository.Seed
{
    public static class SeedData
    {
        public static List<Product> Products => new List<Product>
        {
            // Computers - MSI, Acer, Lenovo
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "MSI Pulse",
                Brand = "MSI",
                Category = "Computers",
                Price = 899.00m,
                Description = "MSI Pulse GL66 15.6\" FHD 144Hz Gaming Laptop: Intel Core i7-12700H RTX 3070 16GB 512GB NVMe SSD",
                ImageFileName = "22866337.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Acer Swift",
                Brand = "Acer",
                Category = "Computers",
                Price = 929.00m,
                Description = "Acer Swift X SFX14-42G-R607 Creator Laptop | 14\" Full HD 100% sRGB | AMD Ryzen 7 5825U",
                ImageFileName = "84600886.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Lenovo Ideapad",
                Brand = "Lenovo",
                Category = "Computers",
                Price = 799.00m,
                Description = "Lenovo 2022 Newest Ideapad 3 Laptop, 15.6\" HD Touchscreen, 11th Gen Intel Core i3-1115G4 Processor, 8GB DDR4 RAM, 256GB PCIe NVMe SSD",
                ImageFileName = "10744695.jpg",
                CreatedAt = DateTime.Now
            },

            // Computers - Dell
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Dell Latitude 7000",
                Brand = "Dell",
                Category = "Computers",
                Price = 1199.00m,
                Description = "Dell Latitude 7000 7430 14\" Notebook - Full HD - 1920 x 1080 - Intel Core i7 12th Gen i7-1265U Deca-core (10 Core) 1.80 GHz",
                ImageFileName = "81882367.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Dell Inspiron 15",
                Brand = "Dell",
                Category = "Computers",
                Price = 989.00m,
                Description = "Dell Inspiron 15 3000 Series 3511 Laptop, 15.6\" FHD Touchscreen, Intel Core i5-1035G1, 32GB",
                ImageFileName = "41732775.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Dell Inspiron 3000",
                Brand = "Dell",
                Category = "Computers",
                Price = 849.00m,
                Description = "Dell 2022 Newest Inspiron 3000 Laptop, 15.6 HD Display, Intel Celeron N4020 Processor, 8GB DDR4 RAM",
                ImageFileName = "63529756.jpg",
                CreatedAt = DateTime.Now
            },

            // Computers - HP
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "HP ENVY 200",
                Brand = "HP",
                Category = "Computers",
                Price = 869.00m,
                Description = "HP 14\" FHD Laptop for Business and Student, AMD Ryzen3 3250U (Beat i5 7200U), 16GB RAM",
                ImageFileName = "10590390.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "HP Pavilion 15",
                Brand = "HP",
                Category = "Computers",
                Price = 789.00m,
                Description = "HP 2023 15\" HD IPS Laptop, Windows 11, Intel Pentium 4-Core Processor Up to 2.70GHz, 8GB RAM",
                ImageFileName = "92970713.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "HP ENVY 14\"",
                Brand = "HP",
                Category = "Computers",
                Price = 779.00m,
                Description = "HP Newest 14\" HD Laptop, Windows 11, Intel Celeron Dual-Core Processor Up to 2.60GHz, 4GB RAM",
                ImageFileName = "16303427.jpg",
                CreatedAt = DateTime.Now
            },

            // Accessories
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Keyboard MK345",
                Brand = "Logitech",
                Category = "Accessories",
                Price = 59.00m,
                Description = "Logitech MK345 Wireless Combo Full-Sized Keyboard with Palm Rest and Mouse",
                ImageFileName = "83655305.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Wireless Mouse",
                Brand = "Amazon",
                Category = "Accessories",
                Price = 39.00m,
                Description = "Amazon Basics Wireless Computer Mouse with USB Nano Receiver - Black",
                ImageFileName = "11677601.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Laptop Bag T210",
                Brand = "Lenovo",
                Category = "Accessories",
                Price = 69.00m,
                Description = "Lenovo Laptop Shoulder Bag T210, 15.6-Inch Laptop or Tablet",
                ImageFileName = "15587367.jpg",
                CreatedAt = DateTime.Now
            },

            // Printers
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Canon Pixma MG3620",
                Brand = "Canon",
                Category = "Printers",
                Price = 99.00m,
                Description = "Canon Pixma MG3620 Wireless All-in-One Color Inkjet Printer with Mobile and Tablet Printing, Black",
                ImageFileName = "12643487.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Brother HL-L2350DW",
                Brand = "Brother",
                Category = "Printers",
                Price = 179.00m,
                Description = "Brother Compact Monochrome Laser Printer, HL-L2350DW, Wireless Printing",
                ImageFileName = "89890247.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Lexmark B3442dw",
                Brand = "Lexmark",
                Category = "Printers",
                Price = 319.00m,
                Description = "Lexmark B3442dw Black and White Laser Printer, Wireless with Ethernet, Mobile-Friendly and Cloud Connection",
                ImageFileName = "91537624.jpg",
                CreatedAt = DateTime.Now
            },

            // Cameras
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Panasonic LUMIX",
                Brand = "Panasonic",
                Category = "Cameras",
                Price = 499.00m,
                Description = "Panasonic LUMIX FZ80 4K Digital Camera, 18.1 Megapixel Video Camera, 60X Zoom",
                ImageFileName = "66899970.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "KODAK PIXPRO",
                Brand = "Kodak",
                Category = "Cameras",
                Price = 299.00m,
                Description = "KODAK PIXPRO Friendly Zoom FZ55-BL 16MP Digital Camera with 5X Optical Zoom",
                ImageFileName = "65286227.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Sony CyberShot",
                Brand = "Sony",
                Category = "Cameras",
                Price = 999.00m,
                Description = "Sony CyberShot RX10 IV with 0.03 Second Auto-Focus & 25x Optical Zoom",
                ImageFileName = "57415624.jpg",
                CreatedAt = DateTime.Now
            },

            // Other
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Garmin DriveSmart",
                Brand = "Garmin",
                Category = "Other",
                Price = 199.00m,
                Description = "Garmin DriveSmart 65, Built-In Voice-Controlled GPS Navigator with 6.95\" High-Res Display , Black",
                ImageFileName = "75241241.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "SAMSUNG SmartTag",
                Brand = "Samsung",
                Category = "Other",
                Price = 89.00m,
                Description = "SAMSUNG Galaxy SmartTag Bluetooth Smart Home Accessory Tracker, Attachment Locator for Lost Keys",
                ImageFileName = "72426380.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Garmin Instinct",
                Brand = "Garmin",
                Category = "Other",
                Price = 79.00m,
                Description = "Garmin Instinct, Rugged Outdoor Watch with GPS, Features Glonass and Galileo",
                ImageFileName = "35640104.jpg",
                CreatedAt = DateTime.Now
            },

            // Phones - Apple
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "iPhone 12",
                Brand = "Apple",
                Category = "Phones",
                Price = 969.00m,
                Description = "Apple iPhone 12, 64GB, Black - Unlocked and compatible with any carrier of choice on GSM and CDMA networks. Tested for battery health and guaranteed to come with a battery that exceeds 90% of original capacity.",
                ImageFileName = "11736965.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "iPhone 13",
                Brand = "Apple",
                Category = "Phones",
                Price = 1299.00m,
                Description = "Apple iPhone 13 Pro 512Go Graphite - Unlocked and compatible with any carrier of choice on GSM and CDMA networks.",
                ImageFileName = "97815739.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "iPhone 14",
                Brand = "Apple",
                Category = "Phones",
                Price = 969.80m,
                Description = "Apple iPhone 14 Pro 128GB Purple",
                ImageFileName = "57380538.jpg",
                CreatedAt = DateTime.Now
            },

            // Phones - Samsung
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Samsung Galaxy S5",
                Brand = "Samsung",
                Category = "Phones",
                Price = 299.00m,
                Description = "Samsung Galaxy S5 16GB Black Unlocked",
                ImageFileName = "80522267.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "SAMSUNG Galaxy S23",
                Brand = "Samsung",
                Category = "Phones",
                Price = 749.00m,
                Description = "SAMSUNG Galaxy S23 Cell Phone, Factory Unlocked Android Smartphone, 256GB Storage, 50MP Camera, Night Mode, Long Battery Life, Adaptive Display, US Version, 2023, Lavender",
                ImageFileName = "66017605.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "SAMSUNG Galaxy Z",
                Brand = "Samsung",
                Category = "Phones",
                Price = 899.00m,
                Description = "SAMSUNG Galaxy Z Flip 3 5G Cell Phone, Factory Unlocked Android Smartphone, 256GB, Flex Mode, Super Steady Camera, Ultra Compact, US Version, Phantom Black",
                ImageFileName = "10967363.jpg",
                CreatedAt = DateTime.Now
            },

            // Phones - Other Brands
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Moto G Power",
                Brand = "Motorola",
                Category = "Phones",
                Price = 699.00m,
                Description = "Moto G Power | 2022 | 3-Day Battery | Unlocked | Made for US by Motorola | 4/128GB | 50 MP Camera | Ice Blue",
                ImageFileName = "69725864.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Nokia G10",
                Brand = "Nokia",
                Category = "Phones",
                Price = 689.00m,
                Description = "Nokia G10 | Android 11 | Unlocked Smartphone | 3-Day Battery | Dual SIM | US Version | 3/32GB | 6.52-Inch Screen | 13MP Triple Camera | Dusk",
                ImageFileName = "46411326.jpg",
                CreatedAt = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "OnePlus Nord N20",
                Brand = "OnePlus",
                Category = "Phones",
                Price = 899.00m,
                Description = "OnePlus Nord N20 5G | Android Smart Phone | 6.43\" AMOLED Display| 6+128GB | Unlocked | 4500 mAh Battery | 33W Fast Charging | Blue Smoke",
                ImageFileName = "17327675.jpg",
                CreatedAt = DateTime.Now
            }
        };
    }
}