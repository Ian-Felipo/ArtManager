using ArtManager.Domain.Entities;
using ArtManager.Domain.Interfaces;
using ArtManager.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtManager.Infrastructure.Repositories;

public class ArtistRepository : EntityRepository<Artist>, IArtistRepository
{
    public ArtistRepository(ArtManagerDbContext artManagerDbContext) : base(artManagerDbContext)
    {
    }

    public IEnumerable<Artist> FilterByName(string name)
    {
        return _artManagerDbContext.Artists
            .Where(artist => artist.Name
            .Contains(name))
            .AsNoTracking()
            .ToList();
    }

    public IEnumerable<Artist> FilterByNationality(string nationality)
    {
        return _artManagerDbContext.Artists
        .Where(artist => artist.Nationality.Contains(nationality))
        .AsNoTracking()
        .ToList();
    }

    public IEnumerable<Artist> FilterByMusicalStyle(string musicalStyle)
    {
        return _artManagerDbContext.Artists
        .Where(artist => artist.MusicalStyles.Any(style => style.Name.ToLower().Contains(musicalStyle.ToLower())))
        .AsNoTracking()
        .ToList();
    }
}