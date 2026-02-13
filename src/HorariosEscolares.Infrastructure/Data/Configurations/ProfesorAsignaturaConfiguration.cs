using HorariosEscolares.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HorariosEscolares.Infrastructure.Data.Configurations;

public class ProfesorAsignaturaConfiguration : IEntityTypeConfiguration<ProfesorAsignatura>
{
    public void Configure(EntityTypeBuilder<ProfesorAsignatura> builder)
    {
        builder.ToTable("ProfesoresAsignaturas");

        // Clave compuesta
        builder.HasKey(pa => new { pa.ProfesorId, pa.AsignaturaId });

        // Relación con Profesor
        builder.HasOne(pa => pa.Profesor)
            .WithMany(p => p.ProfesoresAsignaturas)
            .HasForeignKey(pa => pa.ProfesorId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación con Asignatura
        builder.HasOne(pa => pa.Asignatura)
            .WithMany(a => a.ProfesoresAsignaturas)
            .HasForeignKey(pa => pa.AsignaturaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
