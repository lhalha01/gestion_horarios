using HorariosEscolares.Domain.Entities;
using HorariosEscolares.Domain.Interfaces;
using HorariosEscolares.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HorariosEscolares.Infrastructure.Repositories;

public class HorarioRepository : Repository<Horario>, IHorarioRepository
{
    public HorarioRepository(HorariosDbContext context) : base(context)
    {
    }

    public async Task<Horario?> GetHorarioActivoAsync()
    {
        return await _dbSet
            .Include(h => h.Asignaciones)
                .ThenInclude(a => a.Clase)
                    .ThenInclude(c => c.Nivel)
            .Include(h => h.Asignaciones)
                .ThenInclude(a => a.Asignatura)
            .Include(h => h.Asignaciones)
                .ThenInclude(a => a.Profesor)
            .Include(h => h.Asignaciones)
                .ThenInclude(a => a.Aula)
            .Include(h => h.AprobadoPor)
            .FirstOrDefaultAsync(h => h.Activo);
    }

    public async Task<Horario?> GetHorarioConAsignacionesAsync(int horarioId)
    {
        return await _dbSet
            .Include(h => h.Asignaciones)
                .ThenInclude(a => a.Clase)
                    .ThenInclude(c => c.Nivel)
            .Include(h => h.Asignaciones)
                .ThenInclude(a => a.Asignatura)
            .Include(h => h.Asignaciones)
                .ThenInclude(a => a.Profesor)
            .Include(h => h.Asignaciones)
                .ThenInclude(a => a.Aula)
            .Include(h => h.AprobadoPor)
            .FirstOrDefaultAsync(h => h.Id == horarioId);
    }

    public async Task<IEnumerable<Horario>> GetHorariosPorAnioAsync(string anioEscolar)
    {
        // Note: Currently filtering by FechaInicio year since AnioEscolar property doesn't exist
        // TODO: Add AnioEscolar property to entity and update this method
        return await _dbSet
            .Where(h => h.FechaInicio.Year.ToString() == anioEscolar.Substring(0, 4))
            .Include(h => h.AprobadoPor)
            .OrderByDescending(h => h.CreatedAt)
            .ToListAsync();
    }

    public async Task<IEnumerable<Horario>> GetHorariosAprobadosAsync()
    {
        return await _dbSet
            .Where(h => h.Aprobado)
            .Include(h => h.AprobadoPor)
            .OrderByDescending(h => h.FechaAprobacion)
            .ToListAsync();
    }
}
