using ArtManager.Domain.Entities;

namespace ArtManager.Domain.Specifications;

public class AlbumTitleSpecification : ISpecification<Album>
{
    private readonly StringLengthSpecification<Album> StringLengthSpecification;
    public string ErrorMessage { get; private set; } = string.Empty;

    public AlbumTitleSpecification()
    {
        StringLengthSpecification = new StringLengthSpecification<Album>(1, 20, "Album Title", album => album.Title);
    }

    public bool IsSatisfiedBy(Album album)
    {
        bool isValid = StringLengthSpecification.IsSatisfiedBy(album);
        ErrorMessage = StringLengthSpecification.ErrorMessage;
        return isValid;
    }
}