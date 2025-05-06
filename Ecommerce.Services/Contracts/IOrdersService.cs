using Ecommerce.Entity.Models;
using Ecommerce.Services.Core;

namespace Ecommerce.Services.Contracts;

public interface IOrdersService:IService<Orders>
{
    Task<(List<Orders>,int)> GetAllOrders(int pageIndex = 1, int pageSize = 10);
    Task<(List<Orders>,int)> GetAllByUserId(Guid userId, int pageIndex = 1, int pageSize = 10);
    Task <Orders?> GetUserOrder(Guid userId, Guid orderId);
    Task<Orders?> GetOrderDetails(Guid OrderId);
    Task <List<Orders>> NumOrders(Guid userId);
    Task<Orders?> Updatestatus(Guid orderId,string? payment_status, string? order_status);
}