namespace ArtManager.Domain.Interfaces;

public interface IUnitOfWork
{
    IArtistRepository ArtistRepository { get; }
    IMusicalStyleRepository MusicalStyleRepository { get; }
    IAlbumRepository AlbumRepository { get; }
    IMusicRepository MusicRepository { get; }
    IAssessmentRepository AssessmentRepository { get; }
    
    void Commit();
}