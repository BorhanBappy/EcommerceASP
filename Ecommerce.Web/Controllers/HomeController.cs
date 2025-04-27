using System.Diagnostics;
using Ecommerce.ModelViews;
using Microsoft.AspNetCore.Mvc;
    using Ecommerce.Services.Contracts;
    
    namespace Ecommerce.Controllers;
    
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
    
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetNewArrivalsAsync();
                
            return View(products);
        }
    
        public IActionResult Privacy()
        {
            return View();
        }
    
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }