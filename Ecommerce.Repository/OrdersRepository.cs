using Ecommerce.Entity.Models;
using Ecommerce.Repository.Contracts;
using Ecommerce.Repository.Core;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository;

public class OrdersRepository(ApplicationDbContext context) : Repository<Orders>(context), IOrdersRepository
{
    public async Task<List<Orders>> GetAllOrders(int pageIndex = 1, int pageSize = 10)
    {
        if (pageIndex < 1)
            pageIndex = 1;

        if (pageSize < 1)
            pageSize = 10;

        var query = context.Orders
            .Include(o => o.Client)
            .Include(o => o.Items)
            .ThenInclude(oi => oi.Product)
            .OrderByDescending(o => o.CreatedAt); // Optional: order by latest

        // Apply pagination BEFORE executing the query
        var orders = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return orders;
    }
   
    public async Task<List<Orders>> GetAllByUserId(Guid userId, int pageIndex = 1, int pageSize = 10)
    {
        if (pageIndex < 1)
            pageIndex = 1;

        if (pageSize < 1)
            pageSize = 10;

        // Get all orders for the user with pagination

        IQueryable<Orders> query = context.Orders
            .Include(o => o.Items).OrderByDescending(o => o.Id)
            .Where(o => o.ClientId == userId);

        query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);


        var orders = await query.ToListAsync();

        return orders;
    }

    public async Task<Orders?> GetUserOrder(Guid userId, Guid orderId)
    {
        var order = await context.Orders
            .Include(o => o.Client)
            .Include(o => o.Items)
            .ThenInclude(oi => oi.Product)
            .FirstOrDefaultAsync(o => o.ClientId == userId && o.Id == orderId);

        return order;
    }
    public async Task<Orders?> GetOrderDetails(Guid OrderId)
    {
        // var order = context.Orders.Include(o => o.Items)
        //     .ThenInclude(oi => oi.Product)
        //     .Where(o => o.ClientId == UserID).FirstOrDefaultAsync(o => o.Id == OrderId);
        var order = context.Orders.Include(o => o.Client).Include(o => o.Items)
            .ThenInclude(oi => oi.Product).FirstOrDefaultAsync(o => o.Id == OrderId);
        return await order;
    }
    public async Task<List<Orders>> NumOrders(Guid userId)
    {
        var orders = await context.Orders.Where(o => o.ClientId == userId).ToListAsync();
        return orders;
    }
    public async Task<Orders?> Updatestatus(Guid orderId, string? payment_status, string? order_status)
    {
        var order = await context.Orders.FindAsync(orderId);
        if (order != null)
        {
            order.PaymentStatus = payment_status;
            order.OrderStatus = order_status;
            await context.SaveChangesAsync();
        }
        return order;
    }
}