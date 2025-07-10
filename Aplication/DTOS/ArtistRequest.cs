using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.DTOs;

public class ArtistRequest : IEntityRequest
{
    public string Name { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;
}