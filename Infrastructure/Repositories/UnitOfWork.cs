using ArtManager.Domain.Interfaces;
using ArtManager.Infrastructure.Data;

namespace ArtManager.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ArtManagerDbContext _artManagerDbContext;
    public IArtistRepository ArtistRepository { get; }
    public IMusicalStyleRepository MusicalStyleRepository { get; }
    public IAlbumRepository AlbumRepository { get; }
    public IMusicRepository MusicRepository { get; }
    public IAssessmentRepository AssessmentRepository { get; }

    public UnitOfWork(
        ArtManagerDbContext artManagerDbContext,
        IArtistRepository artistRepository,
        IMusicalStyleRepository musicalStyleRepository,
        IAlbumRepository albumRepository,
        IMusicRepository musicRepository,
        IAssessmentRepository assessmentRepository)
    {
        _artManagerDbContext = artManagerDbContext;
        ArtistRepository = artistRepository;
        MusicalStyleRepository = musicalStyleRepository;
        AlbumRepository = albumRepository;
        MusicRepository = musicRepository;
        AssessmentRepository = assessmentRepository;

    }

    public void Commit()
    {
        _artManagerDbContext.SaveChanges();
    }
}