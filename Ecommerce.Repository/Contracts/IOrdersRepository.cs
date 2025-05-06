using Ecommerce.Entity.Models;
using Ecommerce.Repository.Core;

namespace Ecommerce.Repository.Contracts;

public interface IOrdersRepository:IRepository<Orders>
{
   Task<List<Orders>> GetAllOrders(int pageIndex = 1, int pageSize = 10);

    Task<List<Orders>> GetAllByUserId(Guid userId, int pageIndex = 1, int pageSize = 10);
    Task<Orders?>GetUserOrder(Guid userId, Guid orderId);
    Task<Orders?> GetOrderDetails(Guid OrderId);
      Task<List<Orders>> NumOrders(Guid userId);
    Task<Orders?> Updatestatus(Guid orderId,string? payment_status, string? order_status);

}