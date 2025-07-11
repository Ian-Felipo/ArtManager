namespace ArtManager.Domain.Entities;

public class Album : Base
{
    public string Title { get; private set; }
    public List<Music> Musics { get; private set; }
    public List<Artist> Artists { get; private set; }
    public List<MusicalStyle> MusicalStyles { get; private set; }
}