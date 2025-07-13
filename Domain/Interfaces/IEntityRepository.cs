using System.Linq.Expressions;

namespace ArtManager.Domain.Interfaces;

public interface IEntityRepository<T>
{
    IEnumerable<T> GetAll();
    T? Get(Expression<Func<T,bool>> predicate);
    void Post(T entity);
    void Put(T entity);
    void Delete(T entity);    
}