using HorariosEscolares.Domain.Entities;
using HorariosEscolares.Domain.Enums;
using HorariosEscolares.Domain.Interfaces;
using HorariosEscolares.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HorariosEscolares.Infrastructure.Repositories;

public class ProfesorRepository : Repository<Profesor>, IProfesorRepository
{
    public ProfesorRepository(HorariosDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Profesor>> GetProfesoresActivosAsync()
    {
        return await _dbSet
            .Where(p => p.Activo)
            .OrderBy(p => p.NombreCompleto)
            .ToListAsync();
    }

    public async Task<Profesor?> GetByEmailAsync(string email)
    {
        return await _dbSet
            .FirstOrDefaultAsync(p => p.Email == email);
    }

    public async Task<IEnumerable<Profesor>> GetProfesoresPorAsignaturaAsync(int asignaturaId)
    {
        return await _dbSet
            .Where(p => p.Activo && 
                   p.ProfesoresAsignaturas.Any(pa => pa.AsignaturaId == asignaturaId))
            .Include(p => p.ProfesoresAsignaturas)
                .ThenInclude(pa => pa.Asignatura)
            .OrderBy(p => p.NombreCompleto)
            .ToListAsync();
    }

    public async Task<int> GetCargaHorariaAsync(int profesorId, int horarioId)
    {
        return await _context.AsignacionesPeriodo
            .Where(a => a.ProfesorId == profesorId && a.HorarioId == horarioId)
            .CountAsync();
    }

    public async Task<bool> TieneConflictoHorarioAsync(int profesorId, int horarioId, int dia, int numeroPeriodo, int? asignacionExcluidaId = null)
    {
        var query = _context.AsignacionesPeriodo
            .Where(a => a.ProfesorId == profesorId && 
                   a.HorarioId == horarioId &&
                   a.Dia == (DiaSemana)dia && 
                   a.NumeroPeriodo == numeroPeriodo);

        if (asignacionExcluidaId.HasValue)
        {
            query = query.Where(a => a.Id != asignacionExcluidaId.Value);
        }

        return await query.AnyAsync();
    }
}
