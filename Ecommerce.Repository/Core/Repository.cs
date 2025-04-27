using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Repository.Core;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly DbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(DbContext context)
    {
        _context = context;
        _dbSet   = context.Set<T>();
    }

    public async Task<T?> GetById(Guid id)
    {
        // Assumes your entity T has a single key of type int.
        return await _dbSet.FindAsync(id);
    }

    public virtual async Task<List<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task Add(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        // Attach & mark modified so EF tracks changes
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task Delete(T entity)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }
}