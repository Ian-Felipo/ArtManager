using ArtManager.Aplication.DTOs;

namespace ArtManager.Aplication.Interfaces;

public interface IAlbumService 
{
    IEnumerable<AlbumResponse> FindAllAlbums();
    AlbumResponse FindAlbumtById(AlbumRequest albumRequest);
    AlbumResponse FindAlbumByName(AlbumRequest albumRequest);
    AlbumResponse CreateAlbum(AlbumRequest albumRequest);
    AlbumResponse UpdateAlbum(AlbumRequest albumRequest);
    AlbumResponse RemoveAlbum(AlbumRequest albumRequest);
}