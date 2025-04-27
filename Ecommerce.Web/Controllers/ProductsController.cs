using AutoMapper;
using Ecommerce.Common.DTO;
using Ecommerce.Entity.Models;
using Ecommerce.Models;
using Ecommerce.ModelViews;
using Ecommerce.Repository.Core;
using Ecommerce.Services;
using Ecommerce.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers;

[Authorize(Roles = "Admin")]
[Route("/Admin/[controller]/{action=Index}/{id?}")]
public class ProductsController : Controller
{
    private readonly IProductService _service;
    private readonly IWebHostEnvironment _env;

    private readonly IMapper _mapper;

    public ProductsController(IProductService service, IWebHostEnvironment env, IMapper mapper)
    {
        _service = service;
        _env = env;
        _mapper = mapper;
    }


    // GET: /Admin/Products
    public async Task<IActionResult> Index(int pageIndex = 1, string search = "", string? column = null,
        string? orderBy = null)
    {
        var searchParams = new ProductSearchParams
        {
            PageIndex = pageIndex,
            Search = search,
            Column = column,
            OrderBy = orderBy
        };

        var (products, totalPages) = await _service.GetPagedProductsAsync(searchParams);

        ViewData["PageIndex"] = pageIndex;
        ViewData["TotalPages"] = totalPages;
        ViewData["Search"] = search;
        ViewData["Column"] = column;
        ViewData["OrderBy"] = orderBy;

        return View(products);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductModelViews productModelViews)
    {
        if (!ModelState.IsValid)
        {
            return View(productModelViews);
        }

        // Save the image file
        string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") +
                             Path.GetExtension(productModelViews.ImageFile!.FileName);
        string imageFullPath = Path.Combine(_env.WebRootPath, "products", newFileName);

        using (var stream = System.IO.File.Create(imageFullPath))
        {
            await productModelViews.ImageFile.CopyToAsync(stream);
        }

        // Save the new product in the database

        // var product = new Product
        // {
        //     Name = productModelViews.Name,
        //     Brand = productModelViews.Brand,
        //     Category = productModelViews.Category,
        //     Price = productModelViews.Price,
        //     Description = productModelViews.Description,
        //     ImageFileName = newFileName,
        //     CreatedAt = DateTime.Now
        // };
        var product = _mapper.Map<Product>(productModelViews);
        product.ImageFileName = newFileName;
        product.CreatedAt = DateTime.Now;
        await _service.Add(product);

        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Edit(Guid id)
    {
        var product = await _service.GetById(id);

        if (product == null)
        {
            return RedirectToAction("Index");
        }

        // var productModelViews = new ProductModelViews
        // {
        //     Name = product.Name,
        //     Brand = product.Brand,
        //     Category = product.Category,
        //     Price = product.Price,
        //     Description = product.Description
        // };
        var productModelViews = _mapper.Map<ProductModelViews>(product);

        ViewData["ProductId"] = product.Id;
        ViewData["ImageFileName"] = product.ImageFileName;
        ViewData["CreatedAt"] = product.CreatedAt.ToString("MM/dd/yyyy");

        return View(productModelViews);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Guid id, ProductModelViews productModelViews)
    {
        var product = await _service.GetById(id);

        if (product == null)
        {
            return RedirectToAction("Index");
        }

        if (!ModelState.IsValid)
        {
            ViewData["ProductId"] = product.Id;
            ViewData["ImageFileName"] = product.ImageFileName;
            ViewData["CreatedAt"] = product.CreatedAt.ToString("MM/dd/yyyy");

            return View(productModelViews);
        }

        // Update the image file if a new one is provided
        string newFileName = product.ImageFileName;
        if (productModelViews.ImageFile != null)
        {
            newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") +
                          Path.GetExtension(productModelViews.ImageFile.FileName);
            string imageFullPath = Path.Combine(_env.WebRootPath, "products", newFileName);

            using (var stream = System.IO.File.Create(imageFullPath))
            {
                await productModelViews.ImageFile.CopyToAsync(stream);
            }

            // Delete the old image
            string oldImageFullPath = Path.Combine(_env.WebRootPath, "products", product.ImageFileName);
            if (System.IO.File.Exists(oldImageFullPath))
            {
                System.IO.File.Delete(oldImageFullPath);
            }
        }

        // Update the product in the database
        _mapper.Map(productModelViews, product); // Update entity
        product.ImageFileName = newFileName;
        await _service.Update(product);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Delete(Guid id)
    {
        var product = await _service.GetById(id);

        if (product == null)
        {
            return RedirectToAction("Index");
        }

        // Delete the product image file
        string imageFullPath = Path.Combine(_env.WebRootPath, "products", product.ImageFileName);
        if (System.IO.File.Exists(imageFullPath))
        {
            System.IO.File.Delete(imageFullPath);
        }

        // Delete the product from the database
        await _service.Delete(product);

        return RedirectToAction("Index");
    }
}