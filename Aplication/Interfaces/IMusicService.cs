using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Interfaces;

public interface IMusicService 
{
    IEnumerable<MusicResponse> FindAllMusics();
    MusicResponse FindMusictById(MusicRequest musicRequest);
    MusicResponse FindMusicByName(MusicRequest musicRequest);
    MusicResponse CreateMusic(MusicRequest musicRequest);
    MusicResponse UpdateMusic(MusicRequest musicRequest);
    MusicResponse RemoveMusic(MusicRequest musicRequest);
}