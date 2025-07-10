using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.DTOs;

public class AlbumResponse : IEntityResponse
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
}