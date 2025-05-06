using Ecommerce.Entity.Models;
using Ecommerce.Repository.Contracts;
using Ecommerce.Services.Contracts;
using Ecommerce.Services.Core;

namespace Ecommerce.Services;

public class OrdersService : Service<Orders>, IOrdersService
{
    private readonly IOrdersRepository _ordersRepository;

    public OrdersService(IOrdersRepository ordersRepository)
        : base(ordersRepository)
    {
        _ordersRepository = ordersRepository;
    }

    public async Task<(List<Orders>,int)> GetAllOrders(int pageIndex = 1, int pageSize = 10)
    {
        var orders = await _ordersRepository.GetAllOrders(pageIndex, pageSize);
        decimal count = orders.Count();
        int totalPages = (int)Math.Ceiling(count / pageSize);
        return (orders,totalPages);
    }
    public async Task<(List<Orders>,int)> GetAllByUserId(Guid userId, int pageIndex = 1, int pageSize = 10)
    {
        
        var orders= await _ordersRepository.GetAllByUserId(userId, pageIndex, pageSize);
        
        decimal count = orders.Count();
        int totalPages = (int)Math.Ceiling(count / pageSize);

        return (orders, totalPages);
    }
    public async Task<Orders?> GetUserOrder(Guid userId, Guid orderId)
    {
        var order = await _ordersRepository.GetUserOrder(userId, orderId);
        return order;
    }
    public async Task<Orders?> GetOrderDetails(Guid OrderId)
    {
        var order = await _ordersRepository.GetOrderDetails(OrderId);
        return order;
    }
    public async Task<List<Orders>> NumOrders(Guid userId)
    {
        var orders = await _ordersRepository.NumOrders(userId);
        return orders;
    }
    public async Task<Orders?> Updatestatus(Guid orderId, string? payment_status, string? order_status)
    {
        var order = await _ordersRepository.Updatestatus(orderId, payment_status, order_status);
        return order;
    }
 
}