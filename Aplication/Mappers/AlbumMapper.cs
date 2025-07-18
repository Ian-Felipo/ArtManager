using ArtManager.Domain.Entities;
using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Mappers;

public static class AlbumMapper
{
    public static Album ToAlbum(this AlbumRequest albumRequest, int id)
    {
        return new Album
        (
            id,
            albumRequest.Title
        );
    }

    public static AlbumResponse ToAlbumResponse(this Album album)
    {
        return new AlbumResponse()
        {
            Id = album.Id,
            Title = album.Title
        };
    }
}