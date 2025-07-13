namespace ArtManager.Domain.Entities;

public class Artist : Entity
{
    public string Name { get; }
    public string Nationality { get; }
    public ICollection<MusicalStyle> MusicalStyles { get; }
    public ICollection<Album> Albums { get; }
    public ICollection<Music> Musics { get; }
    public ICollection<Assessment> Assessments { get; }

    protected Artist() { }
    
    public Artist(string name, string nationality)
    {
        Name = name;
        Nationality = nationality;
        MusicalStyles = new List<MusicalStyle>();
        Albums = new List<Album>();
        Musics = new List<Music>();
        Assessments = new List<Assessment>();
    }
}