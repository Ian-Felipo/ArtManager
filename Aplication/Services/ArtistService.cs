using System.Net;
using System.Security.Cryptography.X509Certificates;
using ArtManager.Aplication.DTOs;
using ArtManager.Aplication.Interfaces;
using ArtManager.Aplication.Mappers;
using ArtManager.Domain.Entities;
using ArtManager.Domain.Interfaces;

namespace ArtManager.Aplication.Services;

public class ArtistService : IArtistService
{
    private readonly IUnitOfWork _unitOfWork;

    public ArtistService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<ArtistResponse> FindAllArtists()
    {
        return _unitOfWork.ArtistRepository.FindAll().Select(artist => artist.ToArtistResponse());
    }

    public ArtistResponse FindArtistById(int id)
    {
        var artist = _unitOfWork.ArtistRepository.Find(artist => artist.Id == id);
        if (artist == null) { throw new Exception("Artista não encontrado"); }
        return artist.ToArtistResponse();
    }

    public ArtistResponse FindArtistByName(string name)
    {
        var artist = _unitOfWork.ArtistRepository.Find(artist => artist.Name.ToLower() == name.ToLower());
        if (artist == null) { throw new Exception("Artista não encontrado"); }
        return artist.ToArtistResponse();
    }

    public ArtistResponse CreateArtist(ArtistRequest artistRequest)
    {
        var artist = artistRequest.ToArtist();
        _unitOfWork.ArtistRepository.Create(artist);
        return artist.ToArtistResponse();
    }

    public ArtistResponse RemoveArtistById(int id)
    {
        var artist = _unitOfWork.ArtistRepository.Find(artist => artist.Id == id);
        if (artist == null) { throw new Exception(); }
        _unitOfWork.ArtistRepository.Remove(artist);
        return artist.ToArtistResponse();
    }

    public IEnumerable<ArtistResponse> SearchArtistsByMusicalStyle(string musicalStyle)
    {
        return _unitOfWork.ArtistRepository.SearchByNationality(musicalStyle).Select(artist => artist.ToArtistResponse());

    }

    public IEnumerable<ArtistResponse> SearchArtistsByName(string name)
    {
        return _unitOfWork.ArtistRepository.SearchByNationality(name).Select(artist => artist.ToArtistResponse());

    }

    public IEnumerable<ArtistResponse> SearchArtistsByNationality(string nationality)
    {
        return _unitOfWork.ArtistRepository.SearchByNationality(nationality).Select(artist => artist.ToArtistResponse());
    }

    public ArtistResponse UpdateArtist(ArtistRequest artistRequest, int id)
    {
        var artist = artistRequest.ToArtist(id);
        _unitOfWork.ArtistRepository.Update(artist);
        return artist.ToArtistResponse();
    }
}