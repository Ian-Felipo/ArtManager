using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.DTOs;

public class MusicResponse : IEntityResponse
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
    public int AlbumId { get; set; }
}