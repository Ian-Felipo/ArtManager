using Microsoft.EntityFrameworkCore;
using ArtManager.Domain.Entities;

namespace ArtManager.Infrastructure.Data;

public class ArtManagerDbContext : DbContext
{
    public ArtManagerDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }

    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Assessment> Assessments { get; set; }
    public DbSet<Music> Musics { get; set; }
    public DbSet<MusicalStyle> MusicalStyles { get; set; }
}