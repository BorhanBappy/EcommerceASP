using System.Text.Json;
using Ecommerce.Entity.Models;
using Ecommerce.Entity.Models;
using Ecommerce.Repository.Core;
using Ecommerce.Services.Contracts;

namespace Ecommerce.Services;

public class CartHelper
{
    public static Dictionary<Guid, int> GetCartDictionary(HttpRequest request, HttpResponse response)
    {
        string cookieValue = request.Cookies["shopping_cart"] ?? "";
        Console.WriteLine(cookieValue);
        try
        {
            var cart = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(cookieValue));
            // Console.WriteLine("[CartHelper] cart=" + cookieValue + " -> " + cart);
            var dictionary = JsonSerializer.Deserialize<Dictionary<Guid, int>>(cart);
            if (dictionary != null)
            {
                return dictionary;
            }
        }
        catch (Exception)
        {
        }

        if (cookieValue.Length > 0)
        {
            // this cookie is not valid => delete it
            response.Cookies.Delete("shopping_cart");
        }

        return new Dictionary<Guid, int>();
    }


    public static int GetCartSize(HttpRequest request, HttpResponse response)
    {
        int cartSize = 0;

        var cartDictionary = GetCartDictionary(request, response);
        foreach (var keyValuePair in cartDictionary)
        {
            cartSize += keyValuePair.Value;
        }

        return cartSize;
    }

    public static async Task<List<OrderItems>> GetCartItems(HttpRequest request, HttpResponse response,
        IProductService service)
    {
        var cartItems = new List<OrderItems>();

        var cartDictionary = GetCartDictionary(request, response);
        foreach (var pair in cartDictionary)
        {
            Guid productId = pair.Key;
            int quantity = pair.Value;
            var product = await service.GetById(productId);
            if (product == null) continue;

            var item = new OrderItems
            {
                Quantity = quantity,
                UnitPrice = product.Price,
                Product = product,
            };

            cartItems.Add(item);
        }

        return cartItems;
    }


    public static decimal GetSubtotal(List<OrderItems> cartItems)
    {
        decimal subtotal = 0;

        foreach (var item in cartItems)
        {
            subtotal += item.Quantity * item.UnitPrice;
        }

        return subtotal;
    }
}