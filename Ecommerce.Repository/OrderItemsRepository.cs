using Ecommerce.Entity.Models;
using Ecommerce.Repository.Contracts;
using Ecommerce.Repository.Core;

namespace Ecommerce.Repository;

public class OrderItemsRepository : Repository<OrderItems>, IOrderItemsRepository
{
    public OrderItemsRepository(ApplicationDbContext context) : base(context)
    {
    }
}