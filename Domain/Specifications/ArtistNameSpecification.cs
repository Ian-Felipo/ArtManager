using ArtManager.Domain.Entities;

namespace ArtManager.Domain.Specifications;

public class ArtistNameSpecification : ISpecification<Artist>
{
    private readonly StringLengthSpecification<Artist> StringLengthSpecification;
    public string ErrorMessage { get; private set; } = string.Empty;

    public ArtistNameSpecification(Artist artist)
    {
        StringLengthSpecification = new StringLengthSpecification<Artist>(1, 50, "Artist Name", artist => artist.Name);
    }

    public bool IsSatisfiedBy(Artist artist)
    {
        bool isValid = StringLengthSpecification.IsSatisfiedBy(artist);
        ErrorMessage = StringLengthSpecification.ErrorMessage;
        return isValid;
    }
}