using HorariosEscolares.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HorariosEscolares.Infrastructure.Data.Configurations;

public class ClaseConfiguration : IEntityTypeConfiguration<Clase>
{
    public void Configure(EntityTypeBuilder<Clase> builder)
    {
        builder.ToTable("Clases");

        builder.HasKey(c => c.Id);

        builder.Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(10);

        builder.Property(c => c.CantidadAlumnos)
            .IsRequired()
            .HasDefaultValue(25);

        builder.HasIndex(c => new { c.NivelId, c.Nombre })
            .IsUnique()
            .HasDatabaseName("IX_Clases_Nivel_Nombre");

        builder.HasOne(c => c.Nivel)
            .WithMany(n => n.Clases)
            .HasForeignKey(c => c.NivelId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(c => c.Asignaciones)
            .WithOne(a => a.Clase)
            .HasForeignKey(a => a.ClaseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
