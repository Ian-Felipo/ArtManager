namespace ArtManager.Domain.Entities;

public class Assessment : Entity
{
    public string Title { get; }
    public int Note { get; }
    public string Comment { get; }
    public int UserId { get; }
    public User? User { get; }
    public int ArtistId { get; }
    public Artist? Artist { get; }

    protected Assessment() { }

    public Assessment(string title, int note, string comment, int userId, int artistId)
    {
        Title = title;
        Note = note;
        Comment = comment;
        UserId = userId;
        ArtistId = artistId;
    }
}