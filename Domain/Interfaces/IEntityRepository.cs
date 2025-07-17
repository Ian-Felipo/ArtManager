using System.Linq.Expressions;

namespace ArtManager.Domain.Interfaces;

public interface IEntityRepository<T>
{
    IEnumerable<T> FindAll();
    T? Find(Expression<Func<T,bool>> predicate);
    void Create(T entity);
    void Update(T entity);
    void Remove(T entity);    
}