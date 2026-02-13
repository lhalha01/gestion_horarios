using HorariosEscolares.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HorariosEscolares.Infrastructure.Data;

/// <summary>
/// Contexto de base de datos para el sistema de horarios escolares
/// </summary>
public class HorariosDbContext : DbContext
{
    public HorariosDbContext(DbContextOptions<HorariosDbContext> options) : base(options)
    {
    }

    // DbSets
    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Nivel> Niveles => Set<Nivel>();
    public DbSet<Clase> Clases => Set<Clase>();
    public DbSet<Asignatura> Asignaturas => Set<Asignatura>();
    public DbSet<Profesor> Profesores => Set<Profesor>();
    public DbSet<ProfesorAsignatura> ProfesoresAsignaturas => Set<ProfesorAsignatura>();
    public DbSet<Aula> Aulas => Set<Aula>();
    public DbSet<Horario> Horarios => Set<Horario>();
    public DbSet<AsignacionPeriodo> AsignacionesPeriodo => Set<AsignacionPeriodo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Aplicar todas las configuraciones del assembly actual
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // Configurar filtros globales para soft delete
        modelBuilder.Entity<Usuario>().HasQueryFilter(e => !e.IsDeleted);
        modelBuilder.Entity<Nivel>().HasQueryFilter(e => !e.IsDeleted);
        modelBuilder.Entity<Clase>().HasQueryFilter(e => !e.IsDeleted);
        modelBuilder.Entity<Asignatura>().HasQueryFilter(e => !e.IsDeleted);
        modelBuilder.Entity<Profesor>().HasQueryFilter(e => !e.IsDeleted);
        modelBuilder.Entity<ProfesorAsignatura>().HasQueryFilter(e => !e.IsDeleted);
        modelBuilder.Entity<Aula>().HasQueryFilter(e => !e.IsDeleted);
        modelBuilder.Entity<Horario>().HasQueryFilter(e => !e.IsDeleted);
        modelBuilder.Entity<AsignacionPeriodo>().HasQueryFilter(e => !e.IsDeleted);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // Actualizar timestamps automáticamente
        var entries = ChangeTracker.Entries()
            .Where(e => e.Entity is EntidadBase && 
                       (e.State == EntityState.Added || e.State == EntityState.Modified));

        foreach (var entry in entries)
        {
            var entity = (EntidadBase)entry.Entity;

            if (entry.State == EntityState.Added)
            {
                entity.CreatedAt = DateTime.UtcNow;
            }

            if (entry.State == EntityState.Modified)
            {
                entity.UpdatedAt = DateTime.UtcNow;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
