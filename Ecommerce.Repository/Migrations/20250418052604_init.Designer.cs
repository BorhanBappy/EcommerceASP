﻿// <auto-generated />
using System;
using Ecommerce.Repository.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250418052604_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.Web.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Ecommerce.Web.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFileName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasPrecision(16, 2)
                        .HasColumnType("decimal(16,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3d78bfe3-5cee-44c0-8fad-d2a3a32a6080"),
                            Brand = "MSI",
                            Category = "Computers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 299, DateTimeKind.Local).AddTicks(6148),
                            Description = "MSI Pulse GL66 15.6\" FHD 144Hz Gaming Laptop: Intel Core i7-12700H RTX 3070 16GB 512GB NVMe SSD",
                            ImageFileName = "22866337.jpg",
                            Name = "MSI Pulse",
                            Price = 899.00m
                        },
                        new
                        {
                            Id = new Guid("b3a57173-1cd6-412d-b1a7-5b04a8d782ac"),
                            Brand = "Acer",
                            Category = "Computers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5751),
                            Description = "Acer Swift X SFX14-42G-R607 Creator Laptop | 14\" Full HD 100% sRGB | AMD Ryzen 7 5825U",
                            ImageFileName = "84600886.jpg",
                            Name = "Acer Swift",
                            Price = 929.00m
                        },
                        new
                        {
                            Id = new Guid("2aa4edfc-3e2f-4601-9b3e-b0b4597f8b7f"),
                            Brand = "Lenovo",
                            Category = "Computers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5778),
                            Description = "Lenovo 2022 Newest Ideapad 3 Laptop, 15.6\" HD Touchscreen, 11th Gen Intel Core i3-1115G4 Processor, 8GB DDR4 RAM, 256GB PCIe NVMe SSD",
                            ImageFileName = "10744695.jpg",
                            Name = "Lenovo Ideapad",
                            Price = 799.00m
                        },
                        new
                        {
                            Id = new Guid("cb84f9ee-b8e4-4fb1-9b17-65469df73393"),
                            Brand = "Dell",
                            Category = "Computers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5782),
                            Description = "Dell Latitude 7000 7430 14\" Notebook - Full HD - 1920 x 1080 - Intel Core i7 12th Gen i7-1265U Deca-core (10 Core) 1.80 GHz",
                            ImageFileName = "81882367.jpg",
                            Name = "Dell Latitude 7000",
                            Price = 1199.00m
                        },
                        new
                        {
                            Id = new Guid("485d2638-9660-4f18-b94f-4ab04f3ea47d"),
                            Brand = "Dell",
                            Category = "Computers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5786),
                            Description = "Dell Inspiron 15 3000 Series 3511 Laptop, 15.6\" FHD Touchscreen, Intel Core i5-1035G1, 32GB",
                            ImageFileName = "41732775.jpg",
                            Name = "Dell Inspiron 15",
                            Price = 989.00m
                        },
                        new
                        {
                            Id = new Guid("a69297a7-70fe-4632-9119-acccb13b210f"),
                            Brand = "Dell",
                            Category = "Computers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5803),
                            Description = "Dell 2022 Newest Inspiron 3000 Laptop, 15.6 HD Display, Intel Celeron N4020 Processor, 8GB DDR4 RAM",
                            ImageFileName = "63529756.jpg",
                            Name = "Dell Inspiron 3000",
                            Price = 849.00m
                        },
                        new
                        {
                            Id = new Guid("0eaf1863-55dc-4602-acae-eb9d22dc7572"),
                            Brand = "HP",
                            Category = "Computers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5807),
                            Description = "HP 14\" FHD Laptop for Business and Student, AMD Ryzen3 3250U (Beat i5 7200U), 16GB RAM",
                            ImageFileName = "10590390.jpg",
                            Name = "HP ENVY 200",
                            Price = 869.00m
                        },
                        new
                        {
                            Id = new Guid("edf17ed3-8f12-4872-a8e4-473b29c15a23"),
                            Brand = "HP",
                            Category = "Computers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5811),
                            Description = "HP 2023 15\" HD IPS Laptop, Windows 11, Intel Pentium 4-Core Processor Up to 2.70GHz, 8GB RAM",
                            ImageFileName = "92970713.jpg",
                            Name = "HP Pavilion 15",
                            Price = 789.00m
                        },
                        new
                        {
                            Id = new Guid("277a2d37-d8e6-4e2a-bbe7-691ba7f17945"),
                            Brand = "HP",
                            Category = "Computers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5831),
                            Description = "HP Newest 14\" HD Laptop, Windows 11, Intel Celeron Dual-Core Processor Up to 2.60GHz, 4GB RAM",
                            ImageFileName = "16303427.jpg",
                            Name = "HP ENVY 14\"",
                            Price = 779.00m
                        },
                        new
                        {
                            Id = new Guid("42e8b01f-4a6e-498a-84b8-a0e063de703d"),
                            Brand = "Logitech",
                            Category = "Accessories",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5838),
                            Description = "Logitech MK345 Wireless Combo Full-Sized Keyboard with Palm Rest and Mouse",
                            ImageFileName = "83655305.jpg",
                            Name = "Keyboard MK345",
                            Price = 59.00m
                        },
                        new
                        {
                            Id = new Guid("21319bb6-f618-4aec-ad65-3005f6d6737b"),
                            Brand = "Amazon",
                            Category = "Accessories",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5903),
                            Description = "Amazon Basics Wireless Computer Mouse with USB Nano Receiver - Black",
                            ImageFileName = "11677601.jpg",
                            Name = "Wireless Mouse",
                            Price = 39.00m
                        },
                        new
                        {
                            Id = new Guid("78d292e2-a6c1-423d-be74-a1ebb51527de"),
                            Brand = "Lenovo",
                            Category = "Accessories",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5910),
                            Description = "Lenovo Laptop Shoulder Bag T210, 15.6-Inch Laptop or Tablet",
                            ImageFileName = "15587367.jpg",
                            Name = "Laptop Bag T210",
                            Price = 69.00m
                        },
                        new
                        {
                            Id = new Guid("b897602a-8929-4e5d-b5e5-4662195f233a"),
                            Brand = "Canon",
                            Category = "Printers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5913),
                            Description = "Canon Pixma MG3620 Wireless All-in-One Color Inkjet Printer with Mobile and Tablet Printing, Black",
                            ImageFileName = "12643487.jpg",
                            Name = "Canon Pixma MG3620",
                            Price = 99.00m
                        },
                        new
                        {
                            Id = new Guid("ec9303bd-4753-4663-ae3d-2838e29b7f15"),
                            Brand = "Brother",
                            Category = "Printers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5917),
                            Description = "Brother Compact Monochrome Laser Printer, HL-L2350DW, Wireless Printing",
                            ImageFileName = "89890247.jpg",
                            Name = "Brother HL-L2350DW",
                            Price = 179.00m
                        },
                        new
                        {
                            Id = new Guid("86da0e95-de89-4934-b4d1-2a8396b83999"),
                            Brand = "Lexmark",
                            Category = "Printers",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5921),
                            Description = "Lexmark B3442dw Black and White Laser Printer, Wireless with Ethernet, Mobile-Friendly and Cloud Connection",
                            ImageFileName = "91537624.jpg",
                            Name = "Lexmark B3442dw",
                            Price = 319.00m
                        },
                        new
                        {
                            Id = new Guid("fed29a95-6f8f-4832-bdb9-0c3f4e8eebcf"),
                            Brand = "Panasonic",
                            Category = "Cameras",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5924),
                            Description = "Panasonic LUMIX FZ80 4K Digital Camera, 18.1 Megapixel Video Camera, 60X Zoom",
                            ImageFileName = "66899970.jpg",
                            Name = "Panasonic LUMIX",
                            Price = 499.00m
                        },
                        new
                        {
                            Id = new Guid("2b93af2c-1203-489f-a870-260a41224c9a"),
                            Brand = "Kodak",
                            Category = "Cameras",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5933),
                            Description = "KODAK PIXPRO Friendly Zoom FZ55-BL 16MP Digital Camera with 5X Optical Zoom",
                            ImageFileName = "65286227.jpg",
                            Name = "KODAK PIXPRO",
                            Price = 299.00m
                        },
                        new
                        {
                            Id = new Guid("937f292d-9fc1-40fb-9f24-4ecea084087c"),
                            Brand = "Sony",
                            Category = "Cameras",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5939),
                            Description = "Sony CyberShot RX10 IV with 0.03 Second Auto-Focus & 25x Optical Zoom",
                            ImageFileName = "57415624.jpg",
                            Name = "Sony CyberShot",
                            Price = 999.00m
                        },
                        new
                        {
                            Id = new Guid("c183af94-ee64-435a-ad74-81cb1107dd41"),
                            Brand = "Garmin",
                            Category = "Other",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5942),
                            Description = "Garmin DriveSmart 65, Built-In Voice-Controlled GPS Navigator with 6.95\" High-Res Display , Black",
                            ImageFileName = "75241241.jpg",
                            Name = "Garmin DriveSmart",
                            Price = 199.00m
                        },
                        new
                        {
                            Id = new Guid("cb418017-34a1-4373-a4c6-7d12655bf01a"),
                            Brand = "Samsung",
                            Category = "Other",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5946),
                            Description = "SAMSUNG Galaxy SmartTag Bluetooth Smart Home Accessory Tracker, Attachment Locator for Lost Keys",
                            ImageFileName = "72426380.jpg",
                            Name = "SAMSUNG SmartTag",
                            Price = 89.00m
                        },
                        new
                        {
                            Id = new Guid("f9339c36-b56a-47b1-9d5e-753a92c45e4d"),
                            Brand = "Garmin",
                            Category = "Other",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5950),
                            Description = "Garmin Instinct, Rugged Outdoor Watch with GPS, Features Glonass and Galileo",
                            ImageFileName = "35640104.jpg",
                            Name = "Garmin Instinct",
                            Price = 79.00m
                        },
                        new
                        {
                            Id = new Guid("abfa02db-2f64-4274-862f-d8ea91987669"),
                            Brand = "Apple",
                            Category = "Phones",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5954),
                            Description = "Apple iPhone 12, 64GB, Black - Unlocked and compatible with any carrier of choice on GSM and CDMA networks. Tested for battery health and guaranteed to come with a battery that exceeds 90% of original capacity.",
                            ImageFileName = "11736965.jpg",
                            Name = "iPhone 12",
                            Price = 969.00m
                        },
                        new
                        {
                            Id = new Guid("3aadbaf3-df11-4265-8c69-7a14dac8d8ed"),
                            Brand = "Apple",
                            Category = "Phones",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5958),
                            Description = "Apple iPhone 13 Pro 512Go Graphite - Unlocked and compatible with any carrier of choice on GSM and CDMA networks.",
                            ImageFileName = "97815739.jpg",
                            Name = "iPhone 13",
                            Price = 1299.00m
                        },
                        new
                        {
                            Id = new Guid("234e3f40-4541-43e9-ab47-4483a68146d0"),
                            Brand = "Apple",
                            Category = "Phones",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5962),
                            Description = "Apple iPhone 14 Pro 128GB Purple",
                            ImageFileName = "57380538.jpg",
                            Name = "iPhone 14",
                            Price = 969.80m
                        },
                        new
                        {
                            Id = new Guid("0f991b3f-20ef-446d-93a8-7d492192ad17"),
                            Brand = "Samsung",
                            Category = "Phones",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5969),
                            Description = "Samsung Galaxy S5 16GB Black Unlocked",
                            ImageFileName = "80522267.jpg",
                            Name = "Samsung Galaxy S5",
                            Price = 299.00m
                        },
                        new
                        {
                            Id = new Guid("fe90d82a-bdbf-4ddf-b5b3-a25fc3c3bf33"),
                            Brand = "Samsung",
                            Category = "Phones",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5973),
                            Description = "SAMSUNG Galaxy S23 Cell Phone, Factory Unlocked Android Smartphone, 256GB Storage, 50MP Camera, Night Mode, Long Battery Life, Adaptive Display, US Version, 2023, Lavender",
                            ImageFileName = "66017605.jpg",
                            Name = "SAMSUNG Galaxy S23",
                            Price = 749.00m
                        },
                        new
                        {
                            Id = new Guid("a67c1028-bee1-4b08-8a7d-0af9ebe36f81"),
                            Brand = "Samsung",
                            Category = "Phones",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5976),
                            Description = "SAMSUNG Galaxy Z Flip 3 5G Cell Phone, Factory Unlocked Android Smartphone, 256GB, Flex Mode, Super Steady Camera, Ultra Compact, US Version, Phantom Black",
                            ImageFileName = "10967363.jpg",
                            Name = "SAMSUNG Galaxy Z",
                            Price = 899.00m
                        },
                        new
                        {
                            Id = new Guid("08f63191-c2fa-4145-8aff-5b81f1e32abd"),
                            Brand = "Motorola",
                            Category = "Phones",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5980),
                            Description = "Moto G Power | 2022 | 3-Day Battery | Unlocked | Made for US by Motorola | 4/128GB | 50 MP Camera | Ice Blue",
                            ImageFileName = "69725864.jpg",
                            Name = "Moto G Power",
                            Price = 699.00m
                        },
                        new
                        {
                            Id = new Guid("50dc0bc2-997d-414e-993f-8bb6be9f52c0"),
                            Brand = "Nokia",
                            Category = "Phones",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5984),
                            Description = "Nokia G10 | Android 11 | Unlocked Smartphone | 3-Day Battery | Dual SIM | US Version | 3/32GB | 6.52-Inch Screen | 13MP Triple Camera | Dusk",
                            ImageFileName = "46411326.jpg",
                            Name = "Nokia G10",
                            Price = 689.00m
                        },
                        new
                        {
                            Id = new Guid("ea1be25e-0bd4-4a14-80f7-bac7dc6a251e"),
                            Brand = "OnePlus",
                            Category = "Phones",
                            CreatedAt = new DateTime(2025, 4, 18, 11, 26, 3, 301, DateTimeKind.Local).AddTicks(5987),
                            Description = "OnePlus Nord N20 5G | Android Smart Phone | 6.43\" AMOLED Display| 6+128GB | Unlocked | 4500 mAh Battery | 33W Fast Charging | Blue Smoke",
                            ImageFileName = "17327675.jpg",
                            Name = "OnePlus Nord N20",
                            Price = 899.00m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Ecommerce.Web.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Ecommerce.Web.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ecommerce.Web.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Ecommerce.Web.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
