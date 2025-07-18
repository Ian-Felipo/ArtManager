namespace ArtManager.Domain.Entities;

public class MusicalStyle : Entity
{
    public string Name { get; }
    public ICollection<Artist> Artists { get; }

    protected MusicalStyle() { }

    public MusicalStyle(int id, string name) : base(id)
    {
        Name = name;
        Artists = new List<Artist>();
    }
}