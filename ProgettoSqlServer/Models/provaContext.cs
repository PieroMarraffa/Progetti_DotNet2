using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProgettoSqlServer.Models
{
    public partial class provaContext : DbContext
    {
        public provaContext()
        {
        }

        public provaContext(DbContextOptions<provaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Fatture> Fattures { get; set; } = null!;
        public virtual DbSet<Persona> Personas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7J82TJQ;Database=prova;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fatture>(entity =>
            {
                entity.ToTable("Fatture");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.DataFattura).HasColumnType("datetime");

                entity.Property(e => e.Descrizione)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnName("ID_Cliente");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Fatture)
                    .HasForeignKey<Fatture>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fatture_Persona");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.ToTable("Persona");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cognome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cognome");

                entity.Property(e => e.Nome)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nome");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
