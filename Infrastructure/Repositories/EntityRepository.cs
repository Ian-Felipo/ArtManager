using System.Linq.Expressions;
using ArtManager.Domain.Interfaces;
using ArtManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtManager.Infrastructure.Repositories;

public class EntityRepository<T> : IEntityRepository<T> where T : class
{
    protected readonly ArtManagerDbContext _artManagerDbContext;

    public EntityRepository(ArtManagerDbContext artManagerDbContext)
    {
        _artManagerDbContext = artManagerDbContext;
    }

    public IEnumerable<T> GetAll()
    {
        return _artManagerDbContext.Set<T>().AsNoTracking().ToList();
    }

    public T? Get(Expression<Func<T,bool>> predicate)
    {
        return _artManagerDbContext.Set<T>().AsNoTracking().FirstOrDefault(predicate);
    }

    public void Post(T entity)
    {
        _artManagerDbContext.Set<T>().Add(entity);
        
    }

    public void Put(T entity)
    {
        _artManagerDbContext.Set<T>().Update(entity);
    }
    
    public void Delete(T entity)
    {
        _artManagerDbContext.Set<T>().Remove(entity);
    }
}