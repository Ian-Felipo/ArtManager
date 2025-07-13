using System.Linq.Expressions;

namespace ArtManager.Aplication.Interfaces;

public interface IEntityService
{
    IEnumerable<IEntityResponse> GetAll();
    IEntityResponse Get(Expression<Func<IEntityRequest,bool>> predicate);
    IEntityResponse Post(IEntityRequest entityRequest);
    IEntityResponse Put(IEntityRequest entityRequest);
    IEntityResponse Delete(Expression<Func<IEntityRequest,bool>> predicate);
}