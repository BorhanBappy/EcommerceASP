using Ecommerce.Entity.Models;
using Ecommerce.Repository.Contracts;
using Ecommerce.Repository.Core;
using Ecommerce.Services;
using Ecommerce.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("/Admin/Orders/{action=Index}/{id?}")]
    public class AdminOrdersController : Controller
    {
        private readonly IOrdersService _ordersService;
        private readonly int pageSize = 5;

        public AdminOrdersController(IOrdersService service)
        {
            _ordersService = service;
        }

        public async Task<IActionResult> Index(int pageIndex)
        {
            var (orders, totalPages) = await _ordersService.GetAllOrders(pageIndex, pageSize);
            ViewBag.Orders = orders;
            ViewBag.PageIndex = pageIndex;
            ViewBag.TotalPages = totalPages;

            return View();
        }


        public async  Task<IActionResult> Details(Guid id)
        {
            var order = await _ordersService.GetOrderDetails(id);

            if (order == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.NumOrders = _ordersService.NumOrders(id);


            return View(order);


        }


        public async Task<IActionResult> Edit(Guid orderID, string? payment_status, string? order_status)
        {
            Console.WriteLine($"Edit called with orderID: {orderID}");
            var order = await _ordersService.GetOrderDetails(orderID);
            if (order == null)
            {
                return RedirectToAction("Index");
            }


            if (payment_status == null && order_status == null)
            {
                return RedirectToAction("Details", new { orderID });
            }

            if (payment_status != null)
            {
                order.PaymentStatus = payment_status;
            }

            if (order_status != null)
            {
                order.OrderStatus = order_status;
            }
            
            await _ordersService.Update(order);

            return RedirectToAction("Details", new { orderID });
        }
    }
}