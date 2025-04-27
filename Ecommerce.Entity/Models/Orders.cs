using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Entity.Models;

public class Orders
{   
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public ApplicationUser Client { get; set; }
    public List<OrderItems> Items { get; set; } = new List<OrderItems>();
    [Precision(16,2)]
    public decimal ShippingFee { get; set; }
    
    public string DeliveryAddress { get; set; } = "";
    public string PaymentMethod { get; set; } = "";
    public string PaymentStatus { get; set; } = "";
    public string PaymentDetails { get; set; } = "";
    public string OrderStatus { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}