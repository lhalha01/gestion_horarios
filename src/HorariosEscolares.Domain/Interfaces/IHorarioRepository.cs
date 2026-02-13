using HorariosEscolares.Domain.Entities;

namespace HorariosEscolares.Domain.Interfaces;

/// <summary>
/// Repositorio específico para horarios
/// </summary>
public interface IHorarioRepository : IRepository<Horario>
{
    Task<Horario?> GetHorarioActivoAsync();
    Task<Horario?> GetHorarioConAsignacionesAsync(int horarioId);
    Task<IEnumerable<Horario>> GetHorariosAprobadosAsync();
}
