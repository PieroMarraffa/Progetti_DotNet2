using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CinemaSqlServer.Models
{
    public partial class CinemaContext : DbContext
    {
        public CinemaContext()
        {
        }

        public CinemaContext(DbContextOptions<CinemaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attori> Attoris { get; set; } = null!;
        public virtual DbSet<Film> Films { get; set; } = null!;
        public virtual DbSet<Generi> Generis { get; set; } = null!;
        public virtual DbSet<VistaFilm> VistaFilms { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7J82TJQ;Database=Cinema;Trusted_Connection=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attori>(entity =>
            {
                entity.HasKey(e => e.IdAttore);

                entity.ToTable("Attori");

                entity.Property(e => e.Cognome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.IdFilm);

                entity.ToTable("Film");

                entity.Property(e => e.Titolo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAttoreNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.IdAttore)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Film_Attori");

                entity.HasOne(d => d.IdGenereNavigation)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.IdGenere)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Film_Generi");
            });

            modelBuilder.Entity<Generi>(entity =>
            {
                entity.HasKey(e => e.IdGenere);

                entity.ToTable("Generi");

                entity.Property(e => e.Descrizione)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VistaFilm>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VistaFilm");

                entity.Property(e => e.CognomeAttore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genere)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomeAttore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titolo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
