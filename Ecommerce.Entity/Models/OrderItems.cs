using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Entity.Models;

public class OrderItems
{
    public Guid Id { get; set; }
    public int Quantity { get; set; }
    [Precision(16, 2)] public decimal UnitPrice { get; set; }

    public Product Product { get; set; } = new Product();
}