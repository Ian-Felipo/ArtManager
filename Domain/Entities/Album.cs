namespace ArtManager.Domain.Entities;

public class Album : Base
{
    public string Title { get; set; }
    public List<Music> Musics { get; set; }
    public List<Artist> Artists { get; set; }
    public List<MusicalStyle> MusicalStyles { get; set; }
}