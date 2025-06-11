using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GestionReservas.Data.EF;

public partial class _20251cModel2doPGestionReservasContext : DbContext
{
    public _20251cModel2doPGestionReservasContext()
    {
    }

    public _20251cModel2doPGestionReservasContext(DbContextOptions<_20251cModel2doPGestionReservasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Destino> Destinos { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=2025-1c-Model-2do-P-GestionReservas;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Destino>(entity =>
        {
            entity.HasKey(e => e.IdDestino);

            entity.ToTable("Destino");

            entity.Property(e => e.IdDestino).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(200);
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.IdReserva);

            entity.ToTable("Reserva");

            entity.Property(e => e.FechaFin).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");

            entity.HasOne(d => d.IdDestinoNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdDestino)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reserva_Destino");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
