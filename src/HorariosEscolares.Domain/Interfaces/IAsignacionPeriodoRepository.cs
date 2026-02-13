using HorariosEscolares.Domain.Entities;
using HorariosEscolares.Domain.Enums;

namespace HorariosEscolares.Domain.Interfaces;

/// <summary>
/// Repositorio específico para asignaciones de períodos
/// </summary>
public interface IAsignacionPeriodoRepository : IRepository<AsignacionPeriodo>
{
    Task<IEnumerable<AsignacionPeriodo>> GetPorHorarioAsync(int horarioId);
    Task<IEnumerable<AsignacionPeriodo>> GetPorClaseAsync(int claseId, int horarioId);
    Task<IEnumerable<AsignacionPeriodo>> GetPorProfesorAsync(int profesorId, int horarioId);
    Task<IEnumerable<AsignacionPeriodo>> GetPorAulaAsync(int aulaId, int horarioId);
    Task<bool> ExisteConflictoProfesorAsync(int profesorId, DiaSemana dia, int periodo, int horarioId, int? excludeId = null);
    Task<bool> ExisteConflictoClaseAsync(int claseId, DiaSemana dia, int periodo, int horarioId, int? excludeId = null);
    Task<bool> ExisteConflictoAulaAsync(int aulaId, DiaSemana dia, int periodo, int horarioId, int? excludeId = null);
}
