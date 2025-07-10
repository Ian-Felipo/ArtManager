using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.DTOs;

public class AlbumRequest : IEntityRequest
{
    public string Title { get; set; } = string.Empty;
}