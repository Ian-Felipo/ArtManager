using ArtManager.Aplication.DTOs;
using ArtManager.Domain.Entities;

namespace ArtManager.Aplication.Interfaces;

public interface IMusicalStyleService 
{
    IEnumerable<MusicalStyleResponse> FindAllArtists();
    MusicalStyleResponse FindMusicalStyleById(MusicalStyleRequest musicalStyleRequest);
    MusicalStyleResponse FindMusicalStyleByName(MusicalStyleRequest musicalStyleRequest);
    MusicalStyleResponse CreateMusicalStyle(MusicalStyleRequest musicalStyleRequest);
    MusicalStyleResponse UpdateMusicalStyle(MusicalStyleRequest musicalStyleRequest);
    MusicalStyleResponse RemoveMusicalStyle(MusicalStyleRequest musicalStyleRequest);
}