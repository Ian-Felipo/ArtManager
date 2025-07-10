using ArtManager.Domain.Entities;
using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Mappers;

public static class ArtistMapper
{
    public static Artist ArtistRequestToArtist(this ArtistRequest artistRequest)
    {
        return new Artist
        {
            Name = artistRequest.Name,
            Nationality = artistRequest.Nationality
        };
    }

    public static ArtistResponse ArtistToArtistResponse(this Artist artist)
    {
        return new ArtistResponse
        {
            Id = artist.Id,
            Name = artist.Name,
            Nationality = artist.Nationality
        };
    }
}