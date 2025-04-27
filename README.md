# Ecommerce Note

## Pagination Section

- page in reserve in dot-Net we can not used page we need to used pageIndex

## Registration, Authentication and Authorization

### Dependency Install

- `Microsoft.AspNetCore.Identity.EntityFrameworkCore`

### Inherit IdentityDbContext and add new migration

```csharp
public class ApplicationDbContext : IdentityDbContext
    {
        
    }
```

### Modifying Defult Identity User and Role

```csharp
public class ApplicationUser:IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public DateTime CreatedAt { get; set; }
}


public class ApplicationRole:IdentityRole<Guid>
{
    
}
```

```csharp
public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Call the base method to configure Identity entities
        base.OnModelCreating(modelBuilder);

        // Seed data for the Product entity
        modelBuilder.Entity<Product>().HasData(SeedData.Products);
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}
```

### Resitraing Identity Service

```csharp
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
    {
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireUppercase = true;
        options.Password.RequireLowercase = false;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
```

## Deafult Admin User Database Setup

```csharp
 public static async Task SeedData(UserManager<ApplicationUser>? userManager, RoleManager<ApplicationRole>? roleManager)
    {
        if (userManager == null || roleManager == null)
        {
            Console.WriteLine("UserManager or RoleManager is null.");
            return;
        }

        // Define the admin role
        const string adminRoleName = "Admin";

        // Check if the admin role exists, and create it if not
        if (!await roleManager.RoleExistsAsync(adminRoleName))
        {
            var adminRole = new ApplicationRole { Name = adminRoleName };
            await roleManager.CreateAsync(adminRole);
        }

        // Define the admin user
        const string adminEmail = "admin@example.com";
        const string adminPassword = "Admin@123";

        // Check if the admin user exists, and create it if not
        var adminUser = await userManager.FindByEmailAsync(adminEmail);
        if (adminUser == null)
        {
            adminUser = new ApplicationUser
            {
                UserName = adminEmail,
                Email = adminEmail,
                FirstName = "Admin",
                LastName = "User",
                Address = "Admin Address",
                CreatedAt = DateTime.Now
            };

            var result = await userManager.CreateAsync(adminUser, adminPassword);
            if (result.Succeeded)
            {
                // Assign the admin role to the user
                await userManager.AddToRoleAsync(adminUser, adminRoleName);
            }
            else
            {
                Console.WriteLine("Failed to create admin user: " + string.Join(", ", result.Errors.Select(e => e.Description)));
            }
        }
    }
    
 
 using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
    await UserRoleSeed.SeedData(userManager, roleManager);
}

```
# Software Architecture and Pattern

## Problem not maintain Architecture

### Feature of this code

- Response Data
- Pagination
- String Transformation

```csharp
      public async Task<ActionResult> Index(int page = 1, int pageSize = 5)
       {
           // Simulated API URL
           string apiUrl = "http://localhost:5004/WeatherForecast/GetNames";
       
           // Fetch data from the API
           using var httpClient = new HttpClient();
           var response = await httpClient.GetAsync(apiUrl);
       
           if (!response.IsSuccessStatusCode)
           {
               // Handle API error
               return StatusCode((int)response.StatusCode, "Error fetching data from API");
           }
       
           var apiData = await response.Content.ReadFromJsonAsync<List<string>>();       
           // Pagination logic
           var paginatedNames = apiData
               .Skip((page - 1) * pageSize) // Skip items for previous pages
               .Take(pageSize)             // Take only the items for the current page
               .Select(name => name.ToUpper()) // String transformation: Convert to uppercase
               .ToList();
       
           ViewData["CurrentPage"] = page;
           ViewData["TotalPages"] = (int)Math.Ceiling((double)apiData.Count / pageSize);
       
           return View(paginatedNames);
       }

```

### ❌ সমস্যাগুলো (বিশ্লেষণসহ):

### 🔴 ১. **SRP (Single Responsibility Principle) লঙ্ঘন**

👉 `Index()` method-এর কাজ শুধু view return করা, কিন্তু এখানে:

- HTTP call হচ্ছে
- Pagination হচ্ছে
- Data transformation হচ্ছে (uppercase)

🔧 সমাধান: প্রত্যেক কাজ আলাদা সার্ভিস ক্লাসে ভাগ করে দেওয়া উচিত — যেমন `DataFetchService`, `PaginationService`,
`TransformationService`।

---

### 🔴 ২. **Tight Coupling**

👉 তুমি সরাসরি `HttpClient` এবং `List<string>` এর উপর নির্ভরশীল। ভবিষ্যতে যদি ডেটার ফরম্যাট বা ফেচিং মেথড পাল্টাতে চাও,
তাহলে `Index()` মেথড পরিবর্তন করতে হবে।

🔧 সমাধান: `IDataFetchService` এর মতো interface ব্যবহার করে loose coupling করতে হবে।

---

### 🔴 ৩. **Testability খারাপ**

- শুধুমাত্র API call বা Pagination আলাদা করে test করতে পারো না।
  👉 কারণ: সব কাজ একসাথে Index() method এর ভিতরে tightly coupled।
  তাই পুরো Index() কে integration test করতে হবে, ছোট ছোট unit আলাদা করে test করা যাবে না।

এই মেথডটিকে Unit Test করা খুবই কঠিন, কারণ তুমি mocking করতে পারবে না।

🔧 সমাধান: সব logic আলাদা interface/service-এ নিয়ে গেলে mock করে সহজে টেস্ট করা যাবে।

---

### 🔴 ৫. **No Dependency Injection**

👉 `HttpClient` কে সরাসরি `new` করে বানানো হয়েছে।  
এতে করে:

- Http connection pooling হয় না।
- Test করার সময় mock করা যায় না।

🔧 সমাধান: `IHttpClientFactory` বা `AddHttpClient` দিয়ে DI থেকে inject করা উচিত।

---

### 🔴 ৬. **No Separation of Concerns (SoC)**

👉 Data fetch, pagination, transformation, error handling সব এক জায়গায়। এতে করে কোড পড়া, রক্ষা করা এবং টেস্ট করা কঠিন হয়।

🔧 সমাধান: আলাদা সার্ভিস ও ইন্টারফেসে ভাগ করা উচিত।

---

### 🔴 ৭. **Violation of Open-Closed Principle (OCP)**

👉 যদি তুমি uppercase এর বদলে lowercase করতে চাও, তাহলে controller এর কোড পরিবর্তন করতে হবে।

🔧 সমাধান: Transformation logic আলাদা ইন্টারফেসে দিতে হবে যাতে নতুন behavior add করতে পারো, কোড না বদলে।

---

### Parallel Development সম্ভব না

👉 এই Index() method tightly coupled ভাবে API call, data process আর UI render করছে।
🔻 এর ফলে:
Frontend টিমকে wait করতে হয় backend implementation শেষ না হওয়া পর্যন্ত।
Backend ডেভেলপার আগে কাজ শেষ করবে, তারপর সেই data format অনুযায়ী Frontend কাজ শুরু করতে পারবে।
এতে করে time waste হয়, productivity কমে যায়, এবং Agile approach follow করা কঠিন হয়ে পড়ে।

### সমাধান

Service দিয়ে logic ভাগ করো

```csharp
public class DataFetchService
{
    private readonly HttpClient _httpClient;
    public DataFetchService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public async Task<List<string>> FetchDataAsync(string apiUrl)
    {
        var response = await _httpClient.GetAsync(apiUrl);
        if (response.IsSuccessStatusCode)
        {
            var data = await response.Content.ReadFromJsonAsync<List<string>>();
            return data;
        }
        return new List<string>();
    }
}

//Pagination Service

public class PaginationService 
{
    // Paginate method to handle any data type List<T>
    public List<T> Paginate<T>(List<T> data, int page, int pageSize)
    {
        return data.Skip((page - 1) * pageSize).Take(pageSize).ToList();
    }

    // Calculate total pages based on total items and page size
    public int CalculateTotalPages(int totalItems, int pageSize)
    {
        return (int)Math.Ceiling((double)totalItems / pageSize);
    }
}

//String Transformation Service

public class StringTransformationService 
{
    public List<string> TransformToUpper(List<string> data)
    {
        return data.Select(x => x.ToUpper()).ToList();
    }
}

// Controller

public class Home2Controller : Controller
{

    public async Task<IActionResult> Index(int page = 1, int pageSize = 5)
    {
        string apiUrl = "http://localhost:5004/WeatherForecast/GetNames";

        var dataFetchService = new DataFetchService(new HttpClient());
        var paginationService = new PaginationService();
        var stringTransformationService = new StringTransformationService();
        
        var apiData = await dataFetchService.FetchDataAsync(apiUrl);
        var paginatedData = paginationService.Paginate(apiData, page, pageSize);
        var transformedData = stringTransformationService.TransformToUpper(paginatedData);

        ViewData["CurrentPage"] = page;
        ViewData["TotalPages"] = paginationService.CalculateTotalPages(apiData.Count, pageSize);

        return View(transformedData);
    }
}
```
তুমি যেই কোড লিখছো সেটা আগের তুলনায় অনেক **modular** হয়েছে। তুমি কিছু **SOLID principle** follow করছো, যা খুব ভালো। এখন আমি তোমাকে বিস্তারিতভাবে বুঝিয়ে দিচ্ছি – **এই কোডে কী কী সমস্যা সমাধান হয়েছে**, আর **কী কী সমস্যা এখনো রয়ে গেছে**:

---

## ✅ **যেসব সমস্যা সমাধান হয়েছে**

### 1. 🔹 **Code Reusability বেড়েছে**
- Service গুলো এখন generic বা reusable: যেমন `PaginationService` যেকোনো List<T> এর ওপর কাজ করতে পারে।
- `StringTransformationService` future এ অন্য data source থেকেও data uppercase করতে পারবে।

---

### 2. 🔹 **Separation of Concerns (SoC) বজায় রাখা হয়েছে**
- Controller শুধু coordinating কাজ করছে — নিজে কিছু logic handle করছে না। এটা architecture-এর দিক থেকে ভালো।

---

## 🟨 **যেসব সমস্যা আংশিক সমাধান হয়েছে**

### 1. ⚠ **Single Responsibility Principle (SRP) মানা হয়েছে**

- ✅ Service গুলোর মধ্যে কিছুটা আলাদা করা হয়েছে: `Fetching`, `Pagination`, `Transformation` আলাদা ক্লাসে।
- ❌ কিন্তু `Controller` এর ভিতরেই সব object তৈরি হচ্ছে (`new DataFetchService(...)`) যার মানে এখনো controller business logic-এর বাস্তব implementation-এর সঙ্গে জড়িয়ে আছে।

## ❌ **যেসব সমস্যা এখনো রয়ে গেছে**

### 1. 🔴 **Dependency Injection এখনো করা হয়নি**
```csharp
var dataFetchService = new DataFetchService(new HttpClient());
```
- তুমি Controller-এর ভিতরেই service গুলোর object তৈরি করছো।
- এতে করে **tight coupling** তৈরি হয়, এবং future-এ test/mock করা খুব কঠিন হবে।

🔧 সমাধান: Service গুলোকে `constructor injection` এর মাধ্যমে inject করতে হবে।

---

### 2. 🔴 **Testability এখনো সীমিত**
- তুমি `new HttpClient()` দিয়ে object তৈরি করছো, যেটা test করতে গেলে real HTTP request পাঠাবে।
- এর কারণে **unit test** করা সম্ভব না, integration test করতে হবে।

🔧 সমাধান: `IDataFetchService`, `IPaginationService`, `IStringTransformationService` – এই interfaces তৈরি করে controller constructor এ inject করতে হবে।

---

### 3. 🔴 **Tight Coupling এখনো রয়েছে**
- Controller এর ভিতরে service object তৈরি করায় tightly coupled হয়ে গেছে implementation-এর সাথে।
- কোনো একটা service change করলে controller এও change করতে হবে।

🔧 সমাধান: Interface use করে loosely coupled design করতে হবে।

---

### 4. 🔴 **Parallel Development এখনো সমস্যা**
- যেহেতু controller এখনও real service এর উপরে নির্ভরশীল, তাই frontend developer mock data দিয়ে কাজ করতে পারছে না।
- এই জন্য backend developer code complete না করলে frontend কাজ শুরু করতে পারবে না।

🔧 সমাধান: Interface + Dependency Injection + Mock service use করলে parallel কাজ করা সম্ভব হতো।

---

## 🎯 **Next Step **

তুমি চাইলে আমি পুরোটা modify করে `Clean Architecture` & `SOLID` অনুযায়ী `interfaces` সহ করে দিতে পারি, যেটা fully **testable**, **maintainable**, এবং **scalable**।

### Step 1: Create Interfaces

- **Contracts**: This folder contains interfaces that define the contracts for services and repositories.

```csharp
// This interface defines the contract for data fetching services.
public interface IDataFetchService
{
    Task<List<string>> FetchDataAsync(string apiUrl);
}
// This interface defines the contract for data fetching services.
public interface IPaginationService
{
    List<T> Paginate<T>(List<T> data, int page, int pageSize);
    int CalculateTotalPages(int totalItems, int pageSize); 
}
// This interface defines the contract for string transformation services.
public interface IStringTransformationService
{ 
    List<string> TransformToUpper(List<string> data);
}
```

### Step 2: Modify Controller to Use Injected Services

```csharp
public class WeatherForecastController : Controller
{
    private readonly IDataFetchService _dataFetchService;
    private readonly IPaginationService _paginationService;
    private readonly IStringTransformationService _stringTransformationService;

    public WeatherForecastController(
        IDataFetchService dataFetchService,
        IPaginationService paginationService,
        IStringTransformationService stringTransformationService)
    {
        _dataFetchService = dataFetchService;
        _paginationService = paginationService;
        _stringTransformationService = stringTransformationService;
    }

    public async Task<ActionResult> Index(int page = 1, int pageSize = 5)
    {
        // Simulated API URL
        string apiUrl = "http://localhost:5004/WeatherForecast/GetNames";

        // Fetch data from the API
        var apiData = await _dataFetchService.FetchDataAsync(apiUrl);

        // Pagination logic
        var paginatedNames = _paginationService.Paginate(apiData, page, pageSize);
        paginatedNames = _stringTransformationService.TransformToUpper(paginatedNames);

        ViewData["CurrentPage"] = page;
        ViewData["TotalPages"] = _paginationService.CalculateTotalPages(apiData.Count, pageSize);

        return View(paginatedNames);
    }
}
```

## 🎯 **সমস্যাগুলো কিভাবে সমাধান হলো**

### 1. 🔴 **Dependency Injection চালু করা হয়েছে**
- **সমস্যা:** কন্ট্রোলার নিজেই `new DataFetchService()` দিয়ে সার্ভিস ক্রিয়েট করছিল, ফলে Tight Coupling ছিল।
- **সমাধান:**
    - `IDataFetchService`, `IPaginationService` ইত্যাদি ইন্টারফেস তৈরি করা হয়েছে।
    - কন্ট্রোলার এখন **constructor injection** এর মাধ্যমে সার্ভিসগুলো পায়।
    - **যেকোনো ইমপ্লিমেন্টেশন ব্যবহারের সুযোগ:** DI কন্টেইনারে রেজিস্ট্রেশন পরিবর্তন করে সহজে ইমপ্লিমেন্টেশন স্যুইচ করা যায়। যেমন:
      ```csharp
      // Real implementation with HTTP Client
      builder.Services.AddHttpClient<IDataFetchService, DataFetchService>();
      
      // Mock/Unimplemented version for testing
      builder.Services.AddHttpClient<IDataFetchService, UnImplemented>();
      
      // Pagination & Transformation সার্ভিস রেজিস্টার
      builder.Services.AddScoped<IPaginationService, PaginationService>();
      builder.Services.AddScoped<IStringTransformationService, StringTransformationService>();
      ```
    - **ফলাফল:** কন্ট্রোলারের কোডে কোনো পরিবর্তন ছাড়াই `DataFetchService`-কে `UnImplemented` বা অন্য কোনো ক্লাস দিয়ে রিপ্লেস করা যাবে! 🛠️

---

### 2. 🔴 **Testability বৃদ্ধি পেয়েছে**
- **সমস্যা:** সরাসরি `HttpClient` ব্যবহার করায় ইউনিট টেস্ট করা যাচ্ছিল না।
- **সমাধান:**
    - ইন্টারফেস ব্যবহার করায় টেস্টের সময় **Mock Service** (যেমন: `MockDataFetchService`) ব্যবহার করা যাবে।
    - উদাহরণ:
  ```csharp
  public class MockDataFetchService : IDataFetchService 
  {
      public Task<List<string>> FetchDataAsync(string apiUrl) 
      {
          return Task.FromResult(new List<string> { "Test", "Mock" });
      }
  }
  ```
    - এখন **Moq, NUnit** ইত্যাদি ফ্রেমওয়ার্ক দিয়ে সহজেই ইউনিট টেস্ট লেখা যাবে।

---

### 3. 🔴 **Tight Coupling দূর হয়েছে**
- **সমস্যা:** কন্ট্রোলার সরাসরি কনক্রিট ক্লাসের উপর নির্ভরশীল ছিল।
- **সমাধান:**
    - কন্ট্রোলার এখন শুধুমাত্র **ইন্টারফেসের** উপর নির্ভর করে।
    - সার্ভিসের ইমপ্লিমেন্টেশন বদলালেও কন্ট্রোলারকে আর টাচ করতে হবে না।
    - উদাহরণ: `DataFetchService`-কে `NewDataFetchService` এ পরিবর্তন করলেও কন্ট্রোলার অপরিবর্তিত থাকবে।

---

### 4. 🔴 **Parallel Development সক্ষম হয়েছে**
- **সমস্যা:** ফ্রন্টএন্ড ডেভেলপারদের মক ডেটা দিয়ে কাজ করতে সমস্যা হতো।
- **সমাধান:**
    - ইন্টারফেস থাকায় ফ্রন্টএন্ড ও ব্যাকএন্ড টিম একসাথে কাজ করতে পারবে।
    - ফ্রন্টএন্ড ডেভেলপাররা `IDataFetchService`-এর মক ইমপ্লিমেন্টেশন ব্যবহার করে UI বানাতে পারবে, অথবা Swagger/Postman-এ অপেক্ষা করতে হবে না।

---

## 📌 **মূল নীতিসমূহের প্রতিফলন**
1. **SOLID এর SRP:** প্রতিটি সার্ভিসের দায়িত্ব আলাদা (Fetching, Pagination, Transformation)।
2. **Dependency Inversion Principle (DIP):** হাই-লেভেল মডিউল (কন্ট্রোলার) লো-লেভেল মডিউলের উপর নির্ভরশীল না, বরং ইন্টারফেসের উপর।
3. **Loose Coupling:** সার্ভিসগুলো replaceable এবং swappable।

এই আর্কিটেকচারে অ্যাপ্লিকেশন এখন **Maintainable**, **Scalable**, এবং **Testable**! 🚀

