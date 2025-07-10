using System.Linq.Expressions;

namespace ArtManager.Domain.Interfaces;

public interface IBaseRepository<T>
{
    T Get(Expression<Func<T,bool>> predicate);
    IEnumerable<T> GetAll();
    T Post(T entity);
    T Put(T entity);
    T Delete(Expression<Func<T,bool>> predicate);    
}