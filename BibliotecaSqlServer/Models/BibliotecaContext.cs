using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BibliotecaSqlServer.Models
{
    public partial class BibliotecaContext : DbContext
    {
        public BibliotecaContext()
        {
        }

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autori> Autoris { get; set; } = null!;
        public virtual DbSet<Editori> Editoris { get; set; } = null!;
        public virtual DbSet<Libri> Libris { get; set; } = null!;
        public virtual DbSet<VistaLibri> VistaLibris { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7J82TJQ;Database=Biblioteca;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autori>(entity =>
            {
                entity.HasKey(e => e.IdAutore);

                entity.ToTable("Autori");

                entity.Property(e => e.IdAutore).HasColumnName("ID_Autore");

                entity.Property(e => e.Cognome)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Editori>(entity =>
            {
                entity.HasKey(e => e.IdEditori);

                entity.ToTable("Editori");

                entity.Property(e => e.IdEditori).HasColumnName("ID_Editori");

                entity.Property(e => e.Descrizione)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sede)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Libri>(entity =>
            {
                entity.HasKey(e => e.IdLibri);

                entity.ToTable("Libri");

                entity.Property(e => e.IdLibri).HasColumnName("ID_Libri");

                entity.Property(e => e.IdAutore).HasColumnName("ID_Autore");

                entity.Property(e => e.IdEditore).HasColumnName("ID_Editore");

                entity.Property(e => e.Titolo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAutoreNavigation)
                    .WithMany(p => p.Libris)
                    .HasForeignKey(d => d.IdAutore)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Libri_Autori");

                entity.HasOne(d => d.IdEditoreNavigation)
                    .WithMany(p => p.Libris)
                    .HasForeignKey(d => d.IdEditore)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Libri_Editori");
            });

            modelBuilder.Entity<VistaLibri>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VistaLibri");

                entity.Property(e => e.CognomeAutore)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Cognome Autore");

                entity.Property(e => e.Editore)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdLibri).HasColumnName("ID_Libri");

                entity.Property(e => e.NomeAutore)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nome Autore");

                entity.Property(e => e.Titolo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
