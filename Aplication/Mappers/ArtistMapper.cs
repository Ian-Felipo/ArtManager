using ArtManager.Domain.Entities;
using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Mappers;

public static class ArtistMapper
{
    public static Artist ToArtist(this ArtistRequest artistRequest, int id = 0)
    {
        return new Artist
        (
            id,
            artistRequest.Name,
            artistRequest.Nationality
        );
    }

    public static ArtistResponse ToArtistResponse(this Artist artist)
    {
        return new ArtistResponse()
        {
            Id = artist.Id,
            Name = artist.Name,
            Nationality = artist.Nationality
        };
    }
}