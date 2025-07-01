namespace ArtManager.Domain.Entities;

public class Artist : Base
{
    public string Name { get; set; }
    public string Nationality { get; set; }
    
    public int MusicalStyleId { get; set; }
    public MusicalStyle MusicalStyle { get; set; } 
}