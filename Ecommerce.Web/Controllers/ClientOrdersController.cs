
using Ecommerce.Entity.Models;
using Ecommerce.Repository.Core;
using Ecommerce.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    [Authorize(Roles = "Client")]
    [Route("/Client/Orders/{action=Index}/{id?}")]
    public class ClientOrdersController : Controller
    {
        // private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly int pageSize = 5;
     private readonly IOrdersService _ordersService;

        public ClientOrdersController(    IOrdersService ordersService, UserManager<ApplicationUser> userManager)
        {
            _ordersService = ordersService;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index(int pageIndex)
        {
            var currentUser = await userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return RedirectToAction("Index", "Home");
            }

            

         var (orders,totalPages) = await _ordersService.GetAllByUserId(currentUser.Id, pageIndex, pageSize);



            ViewBag.Orders = orders;
            ViewBag.PageIndex = pageIndex;
            ViewBag.TotalPages = totalPages;

            return View();
        }


        public async Task<IActionResult> Details(Guid id)
        {
            var currentUser = await userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return RedirectToAction("Index", "Home");
            }

           
            var order= await _ordersService.GetUserOrder(currentUser.Id,id );

            if (order == null)
            {
                return RedirectToAction("Index");
            }


            return View(order);
        }
    }
}
