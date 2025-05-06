using Ecommerce.Entity.Models;
using Ecommerce.Repository.Core;
using Ecommerce.Services;
using Ecommerce.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers;

public class CartController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly decimal _shippingFee;
        private readonly ICartService _cartService;
        private readonly IOrdersService _ordersService;

        public CartController(ICartService cartService,IOrdersService ordersService, IConfiguration configuration, UserManager<ApplicationUser> userManager)
        {
            _ordersService = ordersService;
            _cartService = cartService;
            this.userManager = userManager;
            _shippingFee = configuration.GetValue<decimal>("CartSettings:ShippingFee");
        }

        public async Task<ViewResult> Index()
        {
            var cartItems = await _cartService.GetCartItemsAsync(Request, Response);
            var subtotal = _cartService.GetSubtotal(cartItems);


            ViewBag.CartItems = cartItems;
            ViewBag.ShippingFee = _shippingFee;
            ViewBag.Subtotal = subtotal;
            ViewBag.Total = subtotal + _shippingFee;

            return View();
        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Index(CheckoutViewModel model)
        {
            var cartItems = await _cartService.GetCartItemsAsync(Request, Response);
            var subtotal = _cartService.GetSubtotal(cartItems);


            ViewBag.CartItems = cartItems;
            ViewBag.ShippingFee = _shippingFee;
            ViewBag.Subtotal = subtotal;
            ViewBag.Total = subtotal + _shippingFee;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Check if shopping cart is empty or not
            if (cartItems.Count == 0)
            {
                ViewBag.ErrorMessage = "Your cart is empty";
                return View(model);
            }


            TempData["DeliveryAddress"] = model.DeliveryAddress;
            TempData["PaymentMethod"] = model.PaymentMethod;


            if (model.PaymentMethod == "paypal" || model.PaymentMethod == "credit_card")
            {
                return RedirectToAction("Index", "Checkout");
            }

            return RedirectToAction("Confirm");
        }



        public async Task<IActionResult> Confirm()
        {
            var cartItems = await _cartService.GetCartItemsAsync(Request, Response);
            decimal total =_cartService.GetSubtotal(cartItems) + _shippingFee;
            int cartSize = 0;
            foreach (var item in cartItems)
            {
                cartSize += item.Quantity;
            }


            string deliveryAddress = TempData["DeliveryAddress"] as string ?? "";
            string paymentMethod = TempData["PaymentMethod"] as string ?? "";
            TempData.Keep();


            if (cartSize == 0 || deliveryAddress.Length == 0 || paymentMethod.Length == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.DeliveryAddress = deliveryAddress;
            ViewBag.PaymentMethod = paymentMethod;
            ViewBag.Total = total;
            ViewBag.CartSize = cartSize;

            return View();
        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Confirm(Guid any)
        {
            var cartItems = await _cartService.GetCartItemsAsync(Request, Response);

            var deliveryAddress = TempData["DeliveryAddress"] as string ?? "";
            var paymentMethod = TempData["PaymentMethod"] as string ?? "";
            TempData.Keep();

            if (cartItems.Count == 0 || deliveryAddress.Length == 0 || paymentMethod.Length == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            var appUser = await userManager.GetUserAsync(User);
            if (appUser == null)
            {
                return RedirectToAction("Index", "Home");
            }

            // save the order
            var order = new Orders
            {
                ClientId = appUser.Id,
                Items = cartItems,
                ShippingFee = _shippingFee,
                DeliveryAddress = deliveryAddress,
                PaymentMethod = paymentMethod,
                PaymentStatus = "pending",
                PaymentDetails = "",
                OrderStatus = "created",
                CreatedAt = DateTime.Now,
            };
            await _ordersService.Add(order);
           


            // delete the shopping cart cookie
            Response.Cookies.Delete("shopping_cart");

            ViewBag.SuccessMessage = "Order created successfully";

            return View();
        }
    }