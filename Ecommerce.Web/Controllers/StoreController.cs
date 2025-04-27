using Ecommerce.Common.DTO;
using Ecommerce.Entity.Models;
using Ecommerce.Services;
using Ecommerce.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
        
        namespace Ecommerce.Controllers
        {
            public class StoreController : Controller
            {
                private readonly IProductService _service;
        
                public StoreController(IProductService service)
                {
                    _service = service;
                }
        
                public async Task<IActionResult> Index(int pageIndex = 1, string? search = null, string? brand = null, string? category = null, string? sort = null)
                {
                    var searchParams = new StoreSearchParams
                    {
                        PageIndex = pageIndex,
                        Search = search,
                        Brand = brand,
                        Category = category,
                        Sort = sort
                    };
        
                    var (products, totalPages) = await _service.GetStoreProductsAsync(searchParams);
        
                    ViewBag.Products = products;
                    ViewBag.PageIndex = pageIndex;
                    ViewBag.TotalPages = totalPages;
        
                    return View(searchParams);
                }
        
                public async Task<IActionResult> Details(Guid id)
                {
                    var product = await _service.GetById(id);
                    if (product == null)
                    {
                        return RedirectToAction(nameof(Index));
                    }
        
                    return View(product);
                }
            }
        }