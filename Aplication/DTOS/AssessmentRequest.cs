using ArtManager.Aplication.Interfaces;

namespace ArtManager.Aplication.DTOs;

public class AssessmentRequest : IEntityRequest
{
    public string Title { get; set; } = string.Empty;
    public int Note { get; set; }
    public string Comment { get; set; } = string.Empty;
    public int UserId { get; set; }
    public int ArtistId { get; set; }
}