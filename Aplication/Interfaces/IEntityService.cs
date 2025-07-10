using System.Linq.Expressions;

namespace ArtManager.Aplication.Interfaces;

public interface IEntityService
{
    IEntityResponse Get(Expression<Func<IEntityRequest,bool>> predicate);
    IEntityResponse GetById(int id);
    IEnumerable<IEntityResponse> GetAll();
    IEntityResponse Create(IEntityRequest entityRequest);
    IEntityResponse Update(IEntityRequest entityRequest);
    IEntityResponse Delete(Expression<Func<IEntityRequest,bool>> predicate);
}