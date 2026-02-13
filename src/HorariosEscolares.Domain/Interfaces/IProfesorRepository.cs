using HorariosEscolares.Domain.Entities;

namespace HorariosEscolares.Domain.Interfaces;

/// <summary>
/// Repositorio específico para profesores
/// </summary>
public interface IProfesorRepository : IRepository<Profesor>
{
    Task<IEnumerable<Profesor>> GetProfesoresActivosAsync();
    Task<Profesor?> GetByEmailAsync(string email);
    Task<IEnumerable<Profesor>> GetProfesoresPorAsignaturaAsync(int asignaturaId);
    Task<int> GetCargaHorariaAsync(int profesorId, int horarioId);
}
