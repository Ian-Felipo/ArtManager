namespace ArtManager.Domain.Entities;

public class Album : Entity
{
    public string Title { get; }
    public ICollection<Artist> Artists { get; }
    public ICollection<Music> Musics { get; }

    protected Album() { }

    public Album(int id, string title) : base(id)
    {
        Title = title;
        Artists = new List<Artist>();
        Musics = new List<Music>();
    }
}