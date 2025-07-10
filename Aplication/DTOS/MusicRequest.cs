using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.DTOs;

public class MusicRequest : IEntityRequest
{
    public string Title { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
    public int AlbumId { get; set; }
}