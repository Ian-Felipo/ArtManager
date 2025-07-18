namespace ArtManager.Domain.Entities;

public class User : Entity
{
    public string Name { get; }
    public string Email { get; }
    public string Password { get; }
    public ICollection<Assessment> Assessments { get; }

    protected User() { }

    public User(int id, string name, string email, string password) : base(id)
    {
        Name = name;
        Email = email;
        Password = password;
        Assessments = new List<Assessment>();
    }
}