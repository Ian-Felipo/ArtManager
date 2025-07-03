namespace ArtManager.Domain.Entities;

public class Artist : Base
{
    public string Name { get; set; }
    public string Nationality { get; set; }
    public List<Album> Albums { get; set; }
    public List<MusicalStyle> MusicalStyles { get; set; } 
    public List<Assessment> Assessments { get; set; }
}