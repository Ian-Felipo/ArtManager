using ArtManager.Domain.Interfaces;
using ArtManager.Domain.Entities;

namespace ArtManager.Domain.Specifications;

public class ArtistNationalitySpecification : ISpecification<Artist>
{
    private readonly StringLengthSpecification<Artist> StringLengthSpecification;
    public string ErrorMessage { get; private set; } = string.Empty;

    public ArtistNationalitySpecification(Artist artist)
    {
        StringLengthSpecification = new StringLengthSpecification<Artist>(1, 30, "Artist Nationality", artist => artist.Nationality);
    }

    public bool IsSatisfiedBy(Artist artist)
    {
        bool isValid = StringLengthSpecification.IsSatisfiedBy(artist);
        ErrorMessage = StringLengthSpecification.ErrorMessage;
        return isValid;
    }
}