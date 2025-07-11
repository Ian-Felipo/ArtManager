using Microsoft.EntityFrameworkCore;
using ArtManager.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArtManager.Infrastructure.Configurations;

public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
{
    public void Configure(EntityTypeBuilder<Artist> builder)
    {
        builder.ToTable("artists");

        builder.HasKey(artist => artist.Id);

        builder.Property(artist => artist.Id)
            .UseMySqlIdentityColumn()
            .HasColumnName("id")
            .HasColumnType("INT");

        builder.Property(artist => artist.Name)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("name")
            .HasColumnType("VARCHAR(100)");

        builder.HasIndex(artist => artist.Name).IsUnique();

        builder.Property(artist => artist.Nationality)
            .IsRequired()
            .HasMaxLength(100)
            .HasColumnName("nationality")
            .HasColumnType("VARCHAR(100)");

        builder.HasMany(artist => artist.Albums)
            .WithMany(album => album.Artists)
            .UsingEntity(artist_album => artist_album.ToTable("artist_album"));

        builder.HasMany(artist => artist.MusicalStyles)
            .WithMany(musicalStyle => musicalStyle.Artists)
            .UsingEntity(artist_musical_style => artist_musical_style.ToTable("artist_musical_style"));
    }
}