using System.Linq.Expressions;
using ArtManager.Aplication.DTOs;
using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.Services;

public class ArtistService : IArtistService
{
    public IEntityResponse Delete(Expression<Func<IEntityRequest, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ArtistResponse> FilterByMusicalStyle(string musicalStyle)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ArtistResponse> FilterByName(string name)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<ArtistResponse> FilterByNationality(string nationality)
    {
        throw new NotImplementedException();
    }

    public IEntityResponse Get(Expression<Func<IEntityRequest, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<IEntityResponse> GetAll()
    {
        throw new NotImplementedException();
    }

    public IEntityResponse Post(IEntityRequest entityRequest)
    {
        throw new NotImplementedException();
    }

    public IEntityResponse Put(IEntityRequest entityRequest)
    {
        throw new NotImplementedException();
    }
}