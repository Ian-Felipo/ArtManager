namespace ArtManager.Domain.Entities;

public class Music : Base
{
    public string Title { get; set; }
    public TimeSpan Duration { get; set; }
    public int AlbumId { get; set; }
    public Album Album { get; set; }
}