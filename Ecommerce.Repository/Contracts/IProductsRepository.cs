using Ecommerce.Common.DTO;
using Ecommerce.Entity.Models;
using Ecommerce.Repository.Core;

namespace Ecommerce.Repository.Contracts;

public interface IProductsRepository:IRepository<Product>
{
    Task<(List<Product> Items, int TotalPages)> GetPagedProductsAsync(ProductSearchParams searchParams, int pageSize);
    Task<(List<Product> Items, int TotalPages)> GetStoreProductsAsync(StoreSearchParams searchParams, int pageSize);
    Task<List<Product>> GetNewArrivalsAsync();
}