namespace ArtManager.Domain.Entities;

public class MusicalStyle : Base
{
    public string Name { get; set; }
    public List<Album> Albums { get; set; }
}