namespace ArtManager.Domain.Entities;

public class Music : Entity
{
    public string Title { get; }
    public TimeSpan Duration { get; }
    public ICollection<Artist> Artists { get; }
    public int AlbumId { get; }
    public Album? Album { get; }

    protected Music() { }

    public Music(int id, string title, TimeSpan duration, int albumId) : base(id)
    {
        Title = title;
        Duration = duration;
        AlbumId = albumId;
        Artists = new List<Artist>();
    }
}