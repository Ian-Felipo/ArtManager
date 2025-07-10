using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.DTOs;

public class ArtistResponse : IEntityResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;
}