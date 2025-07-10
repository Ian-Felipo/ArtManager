using ArtManager.Domain.Entities;
using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Mappers;

public static class AssessmentMapper
{
    public static Album AlbumRequestToAlbum(this AlbumRequest albumRequest)
    {
        return new Album
        {
            Title = albumRequest.Title,
        };
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