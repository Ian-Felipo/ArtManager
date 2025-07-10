using ArtManager.Domain.Entities;

namespace ArtManager.Domain.Interfaces;

public interface IArtistRepository : IBaseRepository<Artist>
{
    IEnumerable<Artist> FilterByName(string name);
    IEnumerable<Artist> FilterByNationality(string nationality);
    IEnumerable<Artist> FilterByMusicalStyle(string musicalStyle);
}