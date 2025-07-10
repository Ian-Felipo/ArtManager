using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.DTOs;

public class MusicalStyleResponse : IEntityResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}