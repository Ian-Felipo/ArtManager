using System.Linq.Expressions;

namespace ArtManager.Domain.Interfaces;

public interface IEntityRepository<T>
{
    IEnumerable<T> GetAll();
    T Get(Expression<Func<T,bool>> predicate);
    T Post(T entity);
    T Put(T entity);
    T Delete(Expression<Func<T,bool>> predicate);    
}