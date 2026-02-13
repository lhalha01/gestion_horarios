using HorariosEscolares.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HorariosEscolares.Infrastructure.Data.Configurations;

public class ProfesorConfiguration : IEntityTypeConfiguration<Profesor>
{
    public void Configure(EntityTypeBuilder<Profesor> builder)
    {
        builder.ToTable("Profesores");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.NombreCompleto)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(255);

        builder.HasIndex(p => p.Email)
            .IsUnique();

        builder.Property(p => p.Telefono)
            .HasMaxLength(20);

        builder.Property(p => p.MaxHorasSemanales)
            .IsRequired()
            .HasDefaultValue(20);

        builder.Property(p => p.MaxAsignaturas)
            .IsRequired()
            .HasDefaultValue(2);

        builder.Property(p => p.Activo)
            .IsRequired()
            .HasDefaultValue(true);

        builder.HasMany(p => p.ProfesoresAsignaturas)
            .WithOne(pa => pa.Profesor)
            .HasForeignKey(pa => pa.ProfesorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(p => p.Asignaciones)
            .WithOne(a => a.Profesor)
            .HasForeignKey(a => a.ProfesorId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
