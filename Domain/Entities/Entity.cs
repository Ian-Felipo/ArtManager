namespace ArtManager.Domain.Entities;

public abstract class Entity
{
    public int Id { get; }

    public Entity() { }

    public Entity(int id)
    {
        Id = id;
    }
}