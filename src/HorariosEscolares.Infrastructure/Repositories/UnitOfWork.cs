using HorariosEscolares.Domain.Entities;
using HorariosEscolares.Domain.Interfaces;
using HorariosEscolares.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace HorariosEscolares.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly HorariosDbContext _context;
    private IProfesorRepository? _profesorRepository;
    private IHorarioRepository? _horarioRepository;
    private IAsignacionPeriodoRepository? _asignacionPeriodoRepository;
    private IRepository<Usuario>? _usuarioRepository;
    private IRepository<Nivel>? _nivelRepository;
    private IRepository<Clase>? _claseRepository;
    private IRepository<Asignatura>? _asignaturaRepository;
    private IRepository<ProfesorAsignatura>? _profesorAsignaturaRepository;
    private IRepository<Aula>? _aulaRepository;

    public UnitOfWork(HorariosDbContext context)
    {
        _context = context;
    }

    public IProfesorRepository Profesores => 
        _profesorRepository ??= new ProfesorRepository(_context);

    public IHorarioRepository Horarios => 
        _horarioRepository ??= new HorarioRepository(_context);

    public IAsignacionPeriodoRepository AsignacionesPeriodo => 
        _asignacionPeriodoRepository ??= new AsignacionPeriodoRepository(_context);

    public IRepository<Usuario> Usuarios => 
        _usuarioRepository ??= new Repository<Usuario>(_context);

    public IRepository<Nivel> Niveles => 
        _nivelRepository ??= new Repository<Nivel>(_context);

    public IRepository<Clase> Clases => 
        _claseRepository ??= new Repository<Clase>(_context);

    public IRepository<Asignatura> Asignaturas => 
        _asignaturaRepository ??= new Repository<Asignatura>(_context);

    public IRepository<ProfesorAsignatura> ProfesoresAsignaturas => 
        _profesorAsignaturaRepository ??= new Repository<ProfesorAsignatura>(_context);

    public IRepository<Aula> Aulas => 
        _aulaRepository ??= new Repository<Aula>(_context);

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public async Task BeginTransactionAsync()
    {
        await _context.Database.BeginTransactionAsync();
    }

    public async Task CommitTransactionAsync()
    {
        if (_context.Database.CurrentTransaction != null)
        {
            await _context.Database.CommitTransactionAsync();
        }
    }

    public async Task RollbackTransactionAsync()
    {
        if (_context.Database.CurrentTransaction != null)
        {
            await _context.Database.RollbackTransactionAsync();
        }
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
