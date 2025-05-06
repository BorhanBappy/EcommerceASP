// File: Ecommerce.Services/ProductService.cs

using Ecommerce.Common.Common;
using Ecommerce.Entity.Models;
using Ecommerce.Repository.Contracts;
using Ecommerce.Services.Contracts;
using Ecommerce.Services.Core;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Services;

public class ProductService : Service<Product>, IProductService
{
    private readonly IProductsRepository _repository;
    private const int PageSize = 10;

    public ProductService(IProductsRepository repository) : base(repository)
    {
        _repository = repository;
    }

    public async Task<(List<Product>, int)> GetPagedProductsAsync(ProductSearchParams searchParams)
    {
        return await _repository.GetPagedProductsAsync(searchParams, PageSize);
    }

    public async Task<(List<Product>, int)> GetStoreProductsAsync(StoreSearchParams searchParams)
    {
        return await _repository.GetStoreProductsAsync(searchParams, PageSize);
    }

    public async Task<List<Product>> GetNewArrivalsAsync()
    {
        return await _repository.GetNewArrivalsAsync();
    }

}