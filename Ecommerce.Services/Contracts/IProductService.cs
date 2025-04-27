// File: Ecommerce.Services/Contracts/IProductService.cs

using Ecommerce.Common.DTO;
using Ecommerce.Entity.Models;
using Ecommerce.Services.Core;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Services.Contracts;
    
    public interface IProductService : IService<Product>
    {
        Task<(List<Product> Items, int TotalPages)> GetPagedProductsAsync(ProductSearchParams searchParams);
        Task<(List<Product> Items, int TotalPages)> GetStoreProductsAsync(StoreSearchParams searchParams);
        Task<List<Product>> GetNewArrivalsAsync();

    } 