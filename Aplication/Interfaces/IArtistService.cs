using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Interfaces;

public interface IArtistService
{
    IEnumerable<ArtistResponse> FindAllArtists();
    ArtistResponse FindArtistById(int id);
    ArtistResponse FindArtistByName(string name);
    ArtistResponse CreateArtist(ArtistRequest artistRequest);
    ArtistResponse UpdateArtist(ArtistRequest artistRequest, int id);
    ArtistResponse RemoveArtistById(int id);
    IEnumerable<ArtistResponse> SearchArtistsByName(string name);
    IEnumerable<ArtistResponse> SearchArtistsByNationality(string nationality);
    IEnumerable<ArtistResponse> SearchArtistsByMusicalStyle(string musicalStyle);

}