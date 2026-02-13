using HorariosEscolares.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HorariosEscolares.Infrastructure.Data.Configurations;

public class HorarioConfiguration : IEntityTypeConfiguration<Horario>
{
    public void Configure(EntityTypeBuilder<Horario> builder)
    {
        builder.ToTable("Horarios");

        builder.HasKey(h => h.Id);

        builder.Property(h => h.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(h => h.Descripcion)
            .HasMaxLength(500);

        builder.Property(h => h.FechaInicio)
            .IsRequired();

        builder.Property(h => h.FechaFin)
            .IsRequired(false);

        builder.Property(h => h.Activo)
            .IsRequired()
            .HasDefaultValue(true);

        builder.Property(h => h.Aprobado)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(h => h.FechaAprobacion)
            .IsRequired(false);

        // Relación con Usuario (aprobador) - puede ser null
        builder.HasOne(h => h.AprobadoPor)
            .WithMany()
            .HasForeignKey(h => h.AprobadoPorUsuarioId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired(false);

        builder.HasMany(h => h.Asignaciones)
            .WithOne(a => a.Horario)
            .HasForeignKey(a => a.HorarioId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
