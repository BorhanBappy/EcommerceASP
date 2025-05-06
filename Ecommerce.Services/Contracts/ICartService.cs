using Ecommerce.Entity.Models;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Services.Contracts;

public interface ICartService
{
    Task<List<OrderItems>> GetCartItemsAsync(HttpRequest request, HttpResponse response);
    decimal GetSubtotal(List<OrderItems> cartItems);
    int GetCartSize(List<OrderItems> cartItems);
    
}