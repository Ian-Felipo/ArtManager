using System.Data.Common;
using ArtManager.Aplication.DTOs;
using ArtManager.Domain.Entities;

namespace ArtManager.Aplication.Mappers;

public static class MusicMapper
{
    public static Music ToMusic(this MusicRequest musicRequest, int id = 0)
    {
        return new Music
        (
            id,
            musicRequest.Title,
            musicRequest.Duration,
            musicRequest.AlbumId
        );
    }

    public static MusicResponse ToMusicResponse(this Music music)
    {
        return new MusicResponse()
        {
            Id = music.Id,
            Title = music.Title,
            Duration = music.Duration,
            AlbumId = music.AlbumId
        };
    }
}