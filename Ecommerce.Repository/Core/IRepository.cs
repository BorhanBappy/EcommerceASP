namespace Ecommerce.Repository.Core;

public interface IRepository<T> where T : class
{
    Task<T?> GetById(Guid id);
    Task<List<T>> GetAll();
    Task Update(T Entity);
    Task Delete(T Entity);
    Task Add(T Entity);
}