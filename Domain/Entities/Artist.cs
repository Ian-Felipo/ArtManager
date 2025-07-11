namespace ArtManager.Domain.Entities;

public class Artist : Base
{
    public string Name { get; private set; }
    public string Nationality { get; private set; }
    public List<MusicalStyle> MusicalStyles { get; private set; }
    public List<Album> Albums { get; private set; }
    public List<Assessment> Assessments { get; private set; }

    public Artist(string name, string nationality, List<MusicalStyle> musicalStyles, List<Album> albums, List<Assessment> assessments)
    {
        Name = name;
        Nationality = nationality;
        MusicalStyles = musicalStyles;
        Albums = albums;
        Assessments = assessments;
    }
}