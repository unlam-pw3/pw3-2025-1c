using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MundialClubes.Entidades.EF;

public partial class MundialClubesContext : DbContext
{
    public MundialClubesContext()
    {
    }

    public MundialClubesContext(DbContextOptions<MundialClubesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Club> Clubs { get; set; }

    public virtual DbSet<JugadorEstrella> JugadorEstrellas { get; set; }

    public virtual DbSet<Presidente> Presidentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=MundialClubes;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Club>(entity =>
        {
            entity.HasKey(e => e.IdClub);

            entity.ToTable("Club");

            entity.Property(e => e.CamisetaUrl).HasMaxLength(500);
            entity.Property(e => e.EscudoUrl).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Pais).HasMaxLength(50);
        });

        modelBuilder.Entity<JugadorEstrella>(entity =>
        {
            entity.HasKey(e => e.IdJugadorEstrella).HasName("PK__JugadorE__1DBDEACFE498A70A");

            entity.ToTable("JugadorEstrella");

            entity.Property(e => e.FotoUrl).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(250);
        });

        modelBuilder.Entity<Presidente>(entity =>
        {
            entity.HasKey(e => e.IdPresidente);

            entity.ToTable("Presidente");

            entity.HasIndex(e => e.IdClub, "IX_Presidente").IsUnique();

            entity.Property(e => e.Nombre).HasMaxLength(200);

            entity.HasOne(d => d.IdClubNavigation).WithOne(p => p.Presidente)
                .HasForeignKey<Presidente>(d => d.IdClub)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presidente_Club");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
