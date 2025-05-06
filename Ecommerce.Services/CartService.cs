using System.Text.Json;
using Ecommerce.Entity.Models;
using Ecommerce.Services.Contracts;
using Ecommerce.Repository.Contracts;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Services;

public class CartService : ICartService
{
    private readonly IProductsRepository _productRepository;

    public CartService(IProductsRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<OrderItems>> GetCartItemsAsync(HttpRequest request, HttpResponse response)
    {
        var items = new List<OrderItems>();
        var cart = GetCartDictionary(request, response);

        foreach (var pair in cart)
        {
            var product = await _productRepository.GetById(pair.Key);
            if (product == null) continue;

            items.Add(new OrderItems
            {
                Product = product,
                Quantity = pair.Value,
                UnitPrice = product.Price
            });
        }

        return items;
    }

    public decimal GetSubtotal(List<OrderItems> cartItems)
    {
        return cartItems.Sum(i => i.UnitPrice * i.Quantity);
    }

    public int GetCartSize(List<OrderItems> cartItems)
    {
        return cartItems.Sum(i => i.Quantity);
    }

    private Dictionary<Guid, int> GetCartDictionary(HttpRequest request, HttpResponse response)
    {
        string cookieValue = request.Cookies["shopping_cart"] ?? "";
        try
        {
            var json = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(cookieValue));
            var data = JsonSerializer.Deserialize<Dictionary<Guid, int>>(json);
            return data ?? new Dictionary<Guid, int>();
        }
        catch
        {
            if (!string.IsNullOrEmpty(cookieValue))
                response.Cookies.Delete("shopping_cart");
            return new Dictionary<Guid, int>();
        }
    }
}