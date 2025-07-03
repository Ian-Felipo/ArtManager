namespace ArtManager.Domain.Entities;

public class User : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<Assessment> Assessments { get; set; }
}