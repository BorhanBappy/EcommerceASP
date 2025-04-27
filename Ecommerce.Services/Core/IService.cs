namespace Ecommerce.Services.Core;

public interface IService<T> where T : class
{
    Task Add(T Entity);
    Task Delete(T Entity);

    Task<IEnumerable<T>> GetAll();
    Task<T?> GetById(Guid id);
    Task Update(T Entity);
}