using HorariosEscolares.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HorariosEscolares.Infrastructure.Data.Configurations;

public class NivelConfiguration : IEntityTypeConfiguration<Nivel>
{
    public void Configure(EntityTypeBuilder<Nivel> builder)
    {
        builder.ToTable("Niveles");

        builder.HasKey(n => n.Id);

        builder.Property(n => n.Nombre)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(n => n.Descripcion)
            .HasMaxLength(500);

        builder.Property(n => n.Orden)
            .IsRequired();

        builder.HasIndex(n => n.Orden)
            .IsUnique();

        builder.HasMany(n => n.Clases)
            .WithOne(c => c.Nivel)
            .HasForeignKey(c => c.NivelId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
