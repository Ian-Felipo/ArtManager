using ArtManager.Domain.Entities;
using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Mappers;

public static class AlbumMapper
{
    public static Album AlbumRequestToAlbum(this AlbumRequest albumRequest)
    {
        return new Album(albumRequest.Title);
    }

    public static AlbumResponse AlbumToAlbumResponse(this Album album)
    {
        return new AlbumResponse
        {
            Id = album.Id,
            Title = album.Title
        };
    }
}