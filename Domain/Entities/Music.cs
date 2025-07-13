namespace ArtManager.Domain.Entities;

public class Music : Entity
{
    public string Title { get; }
    public TimeSpan Duration { get; }
    public int AlbumId { get; }
    public Album? Album { get; }

    protected Music() { }

    public Music(string title, TimeSpan duration, int albumId)
    {
        Title = title;
        Duration = duration;
        AlbumId = albumId;
    }
}