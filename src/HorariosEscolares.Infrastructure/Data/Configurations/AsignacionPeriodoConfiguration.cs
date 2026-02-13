using HorariosEscolares.Domain.Entities;
using HorariosEscolares.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HorariosEscolares.Infrastructure.Data.Configurations;

public class AsignacionPeriodoConfiguration : IEntityTypeConfiguration<AsignacionPeriodo>
{
    public void Configure(EntityTypeBuilder<AsignacionPeriodo> builder)
    {
        builder.ToTable("AsignacionesPeriodo");

        builder.HasKey(ap => ap.Id);

        builder.Property(ap => ap.Dia)
            .IsRequired()
            .HasConversion<int>();

        builder.Property(ap => ap.NumeroPeriodo)
            .IsRequired();

        builder.Property(ap => ap.HoraInicio)
            .IsRequired();

        builder.Property(ap => ap.HoraFin)
            .IsRequired();

        // Índice único compuesto para prevenir conflictos de horario
        // Una clase no puede tener dos asignaciones al mismo tiempo
        builder.HasIndex(ap => new { ap.HorarioId, ap.ClaseId, ap.Dia, ap.NumeroPeriodo })
            .IsUnique()
            .HasDatabaseName("IX_AsignacionesPeriodo_HorarioClaseDiaPeriodo");

        // Índice adicional para detectar conflictos de profesor
        builder.HasIndex(ap => new { ap.HorarioId, ap.ProfesorId, ap.Dia, ap.NumeroPeriodo })
            .HasDatabaseName("IX_AsignacionesPeriodo_HorarioProfesorDiaPeriodo");

        // Índice adicional para detectar conflictos de aula
        builder.HasIndex(ap => new { ap.HorarioId, ap.AulaId, ap.Dia, ap.NumeroPeriodo })
            .HasDatabaseName("IX_AsignacionesPeriodo_HorarioAulaDiaPeriodo");

        // Relación con Horario
        builder.HasOne(ap => ap.Horario)
            .WithMany(h => h.Asignaciones)
            .HasForeignKey(ap => ap.HorarioId)
            .OnDelete(DeleteBehavior.Cascade);

        // Relación con Clase
        builder.HasOne(ap => ap.Clase)
            .WithMany(c => c.Asignaciones)
            .HasForeignKey(ap => ap.ClaseId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación con Asignatura
        builder.HasOne(ap => ap.Asignatura)
            .WithMany(a => a.Asignaciones)
            .HasForeignKey(ap => ap.AsignaturaId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación con Profesor
        builder.HasOne(ap => ap.Profesor)
            .WithMany(p => p.Asignaciones)
            .HasForeignKey(ap => ap.ProfesorId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación con Aula
        builder.HasOne(ap => ap.Aula)
            .WithMany(a => a.Asignaciones)
            .HasForeignKey(ap => ap.AulaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
