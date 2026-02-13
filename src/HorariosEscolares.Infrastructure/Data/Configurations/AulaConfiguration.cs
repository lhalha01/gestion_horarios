using HorariosEscolares.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HorariosEscolares.Infrastructure.Data.Configurations;

public class AulaConfiguration : IEntityTypeConfiguration<Aula>
{
    public void Configure(EntityTypeBuilder<Aula> builder)
    {
        builder.ToTable("Aulas");

        builder.HasKey(a => a.Id);

        builder.Property(a => a.Codigo)
            .IsRequired()
            .HasMaxLength(20);

        builder.HasIndex(a => a.Codigo)
            .IsUnique();

        builder.Property(a => a.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.Capacidad)
            .IsRequired()
            .HasDefaultValue(30);

        builder.Property(a => a.Disponible)
            .IsRequired()
            .HasDefaultValue(true);

        builder.HasMany(a => a.Asignaciones)
            .WithOne(asig => asig.Aula)
            .HasForeignKey(asig => asig.AulaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
