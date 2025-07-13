using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Interfaces;

public interface IArtistService : IEntityService
{
    IEnumerable<ArtistResponse> FilterByName(string name);
    IEnumerable<ArtistResponse> FilterByNationality(string nationality);
    IEnumerable<ArtistResponse> FilterByMusicalStyle(string musicalStyle);
}