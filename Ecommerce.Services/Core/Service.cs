using Ecommerce.Repository.Core;

namespace Ecommerce.Services.Core;

public class Service<T> : IService<T> where T : class
{
    private readonly IRepository<T> _repository;

    public Service(IRepository<T> repository)
    {
        _repository = repository;
    }

    public async Task Add(T entity)
    {
        await _repository.Add(entity);
    }

    public async Task Delete(T entity)
    {
        await _repository.Delete(entity);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _repository.GetAll();
    }

    public async Task<T?> GetById(Guid id)
    {
        return await _repository.GetById(id);
    }

    public async Task Update(T entity)
    {
        await _repository.Update(entity);
    }
}