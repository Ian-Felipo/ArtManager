namespace ArtManager.Domain.Entities;

public class Assessment : Base
{
    public string Title { get; set; }
    public int Note { get; set; }
    public string Comment { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int ArtistId { get; set; }
    public Artist Artist { get; set; }
}