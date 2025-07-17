using ArtManager.Domain.Entities;

namespace ArtManager.Domain.Interfaces;

public interface IArtistRepository : IEntityRepository<Artist>
{
    IEnumerable<Artist> SearchByName(string name);
    IEnumerable<Artist> SearchByNationality(string nationality);
    IEnumerable<Artist> SearchByMusicalStyle(string musicalStyle);
}