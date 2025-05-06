using Ecommerce.Common.Common;
using Ecommerce.Entity.Models;
using Ecommerce.Repository.Contracts;
using Ecommerce.Repository.Core;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository;

public class ProductsRepository(ApplicationDbContext context) : Repository<Product>(context), IProductsRepository
{
    
    public  async Task<List<Product>> GetNewArrivalsAsync()
    {
        return await context.Products
            .OrderByDescending(p => p.CreatedAt)
            .Take(4)
            .ToListAsync();
    }


    
    public async Task<(List<Product>, int)> GetPagedProductsAsync(ProductSearchParams searchParams, int pageSize)
    {
        IQueryable<Product> query = context.Products;

        // Search
        if (!string.IsNullOrEmpty(searchParams.Search))
        {
            query = query.Where(p =>
                p.Name.Contains(searchParams.Search) ||
                p.Brand.Contains(searchParams.Search) ||
                p.Category.Contains(searchParams.Search));
        }

        // Sorting
        var validColumns = new[] { "Name", "Brand", "Category", "Price", "CreatedAt" };
        var validOrder = new[] { "asc", "desc" };

        string? column = validColumns.Contains(searchParams.Column) ? searchParams.Column : "CreatedAt";
        string? order = validOrder.Contains(searchParams.OrderBy) ? searchParams.OrderBy : "desc";

        query = column switch
        {
            "Name" => order == "asc" ? query.OrderBy(p => p.Name) : query.OrderByDescending(p => p.Name),
            "Brand" => order == "asc" ? query.OrderBy(p => p.Brand) : query.OrderByDescending(p => p.Brand),
            "Category" => order == "asc" ? query.OrderBy(p => p.Category) : query.OrderByDescending(p => p.Category),
            "Price" => order == "asc" ? query.OrderBy(p => p.Price) : query.OrderByDescending(p => p.Price),
            _ => order == "asc" ? query.OrderBy(p => p.CreatedAt) : query.OrderByDescending(p => p.CreatedAt),
        };

        return await PaginateAsync(query, searchParams.PageIndex, pageSize);
    }

    public async Task<(List<Product>, int)> GetStoreProductsAsync(StoreSearchParams searchParams, int pageSize)
    {
        IQueryable<Product> query = context.Products;

        // Filters
        if (!string.IsNullOrWhiteSpace(searchParams.Search))
            query = query.Where(p => p.Name.Contains(searchParams.Search));

        if (!string.IsNullOrWhiteSpace(searchParams.Brand))
            query = query.Where(p => p.Brand.Contains(searchParams.Brand));

        if (!string.IsNullOrWhiteSpace(searchParams.Category))
            query = query.Where(p => p.Category.Contains(searchParams.Category));

        // Sorting
        query = searchParams.Sort switch
        {
            "price_asc" => query.OrderBy(p => p.Price),
            "price_desc" => query.OrderByDescending(p => p.Price),
            _ => query.OrderByDescending(p => p.Id)
        };

        return await PaginateAsync(query, searchParams.PageIndex, pageSize);
    }

    // 🔸 Shared Pagination Helper Method
    private static async Task<(List<Product>, int)> PaginateAsync(IQueryable<Product> query, int pageIndex, int pageSize)
    {
        if (pageIndex < 1) pageIndex = 1;

        var totalItems = await query.CountAsync();
        var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

        var items = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (items, totalPages);
    }
}
