using ArtManager.Domain.Entities;
using ArtManager.Domain.Interfaces;
using ArtManager.Infrastructure.Data;

namespace ArtManager.Infrastructure.Repositories;

public class ArtistRepository : IArtistRepository, EntityRepository<Artist>
{
    private readonly ArtManagerDbContext _artManagerDbContext;

    public ArtistRepository(ArtManagerDbContext artManagerDbContext) : base(artManagerDbContext)
    {
        _artManagerDbContext = artManagerDbContext;
    }    


}