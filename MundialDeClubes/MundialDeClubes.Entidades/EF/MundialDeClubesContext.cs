using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MundialDeClubes.Entidades.EF;

public partial class MundialDeClubesContext : DbContext
{
    public MundialDeClubesContext()
    {
    }

    public MundialDeClubesContext(DbContextOptions<MundialDeClubesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Club> Clubs { get; set; }

    public virtual DbSet<JugadorEstrella> JugadorEstrellas { get; set; }

    public virtual DbSet<Presidente> Presidentes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-JPM48D3\\SQLEXPRESS;Database=MundialDeClubes;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Club>(entity =>
        {
            entity.HasKey(e => e.IdClub);

            entity.ToTable("Club");

            entity.HasIndex(e => e.IdClub, "IX_Club");

            entity.Property(e => e.CamisetaUrl).HasMaxLength(500);
            entity.Property(e => e.EscudoUrl).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Pais).HasMaxLength(200);
        });

        modelBuilder.Entity<JugadorEstrella>(entity =>
        {
            entity.HasKey(e => e.IdJugadorEstrella);

            entity.ToTable("JugadorEstrella");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.Edad).HasMaxLength(200);
            entity.Property(e => e.FotoUrl).HasMaxLength(500);
            entity.Property(e => e.Nombre).HasMaxLength(200);

            entity.HasOne(d => d.IdClubNavigation).WithMany(p => p.JugadorEstrellas)
                .HasForeignKey(d => d.IdClub)
                .HasConstraintName("FK_JugadorEstrella_Club");
        });

        modelBuilder.Entity<Presidente>(entity =>
        {
            entity.HasKey(e => e.IdPresidente);

            entity.ToTable("Presidente");

            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.IdClubNavigation).WithMany(p => p.Presidentes)
                .HasForeignKey(d => d.IdClub)
                .HasConstraintName("FK_Presidente_Club");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
