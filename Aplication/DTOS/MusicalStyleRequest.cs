using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.DTOs;

public class MusicalStyleRequest : IEntityRequest
{
    public string Name { get; set; } = string.Empty;
}