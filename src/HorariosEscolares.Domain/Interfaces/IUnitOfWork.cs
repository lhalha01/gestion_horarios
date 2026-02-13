using HorariosEscolares.Domain.Entities;

namespace HorariosEscolares.Domain.Interfaces;

/// <summary>
/// Patrón Unit of Work para coordinar transacciones entre repositorios
/// </summary>
public interface IUnitOfWork : IDisposable
{
    IRepository<Usuario> Usuarios { get; }
    IRepository<Nivel> Niveles { get; }
    IRepository<Clase> Clases { get; }
    IRepository<Asignatura> Asignaturas { get; }
    IProfesorRepository Profesores { get; }
    IRepository<Aula> Aulas { get; }
    IHorarioRepository Horarios { get; }
    IAsignacionPeriodoRepository AsignacionesPeriodo { get; }
    
    Task<int> SaveChangesAsync();
    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}
