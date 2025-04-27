using Ecommerce.Entity.Models;
using Ecommerce.Repository.Contracts;
using Ecommerce.Repository.Core;

namespace Ecommerce.Repository;

public class OrdersRepository : Repository<Orders>, IOrdersRepository
{
    public OrdersRepository(ApplicationDbContext context) : base(context) { }
}