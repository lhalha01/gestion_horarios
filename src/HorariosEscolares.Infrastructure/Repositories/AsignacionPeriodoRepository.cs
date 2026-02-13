using HorariosEscolares.Domain.Entities;
using HorariosEscolares.Domain.Enums;
using HorariosEscolares.Domain.Interfaces;
using HorariosEscolares.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HorariosEscolares.Infrastructure.Repositories;

public class AsignacionPeriodoRepository : Repository<AsignacionPeriodo>, IAsignacionPeriodoRepository
{
    public AsignacionPeriodoRepository(HorariosDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<AsignacionPeriodo>> GetPorHorarioAsync(int horarioId)
    {
        return await _dbSet
            .Where(a => a.HorarioId == horarioId)
            .Include(a => a.Clase)
                .ThenInclude(c => c.Nivel)
            .Include(a => a.Asignatura)
            .Include(a => a.Profesor)
            .Include(a => a.Aula)
            .OrderBy(a => a.Dia)
            .ThenBy(a => a.NumeroPeriodo)
            .ToListAsync();
    }

    public async Task<IEnumerable<AsignacionPeriodo>> GetPorClaseAsync(int claseId, int horarioId)
    {
        return await _dbSet
            .Where(a => a.ClaseId == claseId && a.HorarioId == horarioId)
            .Include(a => a.Asignatura)
            .Include(a => a.Profesor)
            .Include(a => a.Aula)
            .OrderBy(a => a.Dia)
            .ThenBy(a => a.NumeroPeriodo)
            .ToListAsync();
    }

    public async Task<IEnumerable<AsignacionPeriodo>> GetPorProfesorAsync(int profesorId, int horarioId)
    {
        return await _dbSet
            .Where(a => a.ProfesorId == profesorId && a.HorarioId == horarioId)
            .Include(a => a.Clase)
                .ThenInclude(c => c.Nivel)
            .Include(a => a.Asignatura)
            .Include(a => a.Aula)
            .OrderBy(a => a.Dia)
            .ThenBy(a => a.NumeroPeriodo)
            .ToListAsync();
    }

    public async Task<IEnumerable<AsignacionPeriodo>> GetPorAulaAsync(int aulaId, int horarioId)
    {
        return await _dbSet
            .Where(a => a.AulaId == aulaId && a.HorarioId == horarioId)
            .Include(a => a.Clase)
                .ThenInclude(c => c.Nivel)
            .Include(a => a.Asignatura)
            .Include(a => a.Profesor)
            .OrderBy(a => a.Dia)
            .ThenBy(a => a.NumeroPeriodo)
            .ToListAsync();
    }

    public async Task<bool> ExisteConflictoProfesorAsync(int profesorId, DiaSemana dia, int periodo, int horarioId, int? excludeId = null)
    {
        var query = _dbSet
            .Where(a => a.ProfesorId == profesorId && 
                   a.HorarioId == horarioId &&
                   a.Dia == dia && 
                   a.NumeroPeriodo == periodo);

        if (excludeId.HasValue)
        {
            query = query.Where(a => a.Id != excludeId.Value);
        }

        return await query.AnyAsync();
    }

    public async Task<bool> ExisteConflictoClaseAsync(int claseId, DiaSemana dia, int periodo, int horarioId, int? excludeId = null)
    {
        var query = _dbSet
            .Where(a => a.ClaseId == claseId && 
                   a.HorarioId == horarioId &&
                   a.Dia == dia && 
                   a.NumeroPeriodo == periodo);

        if (excludeId.HasValue)
        {
            query = query.Where(a => a.Id != excludeId.Value);
        }

        return await query.AnyAsync();
    }

    public async Task<bool> ExisteConflictoAulaAsync(int aulaId, DiaSemana dia, int periodo, int horarioId, int? excludeId = null)
    {
        var query = _dbSet
            .Where(a => a.AulaId == aulaId && 
                   a.HorarioId == horarioId &&
                   a.Dia == dia && 
                   a.NumeroPeriodo == periodo);

        if (excludeId.HasValue)
        {
            query = query.Where(a => a.Id != excludeId.Value);
        }

        return await query.AnyAsync();
    }
}
