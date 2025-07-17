namespace ArtManager.Domain.Entities;

public abstract class Entity
{
    public int Id { get; }

    public Entity(int id)
    {
        Id = id;
    }
}