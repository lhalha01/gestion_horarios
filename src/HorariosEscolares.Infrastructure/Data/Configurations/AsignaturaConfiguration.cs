using HorariosEscolares.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HorariosEscolares.Infrastructure.Data.Configurations;

public class AsignaturaConfiguration : IEntityTypeConfiguration<Asignatura>
{
    public void Configure(EntityTypeBuilder<Asignatura> builder)
    {
        builder.ToTable("Asignaturas");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.Codigo)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasIndex(a => a.Codigo)
            .IsUnique();

        builder.Property(a => a.HorasSemanales)
            .IsRequired();

        builder.Property(a => a.Descripcion)
            .HasMaxLength(1000);

        builder.Property(a => a.Color)
            .HasMaxLength(7); // #RRGGBB

        builder.HasMany(a => a.ProfesoresAsignaturas)
            .WithOne(pa => pa.Asignatura)
            .HasForeignKey(pa => pa.AsignaturaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(a => a.Asignaciones)
            .WithOne(ap => ap.Asignatura)
            .HasForeignKey(ap => ap.AsignaturaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
