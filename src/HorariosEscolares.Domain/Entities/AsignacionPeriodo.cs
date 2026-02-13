using HorariosEscolares.Domain.Enums;

namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Asignación de un período específico en el horario
/// Representa una clase en un día y período específico
/// </summary>
public class AsignacionPeriodo : EntidadBase
{
    public int HorarioId { get; set; }
    public int ClaseId { get; set; }
    public int AsignaturaId { get; set; }
    public int ProfesorId { get; set; }
    public int? AulaId { get; set; }
    
    public DiaSemana Dia { get; set; }
    public int NumeroPeriodo { get; set; } // 1-5 (períodos del día)
    
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }
    
    public string? Observaciones { get; set; }
    
    // Navegación
    public Horario Horario { get; set; } = null!;
    public Clase Clase { get; set; } = null!;
    public Asignatura Asignatura { get; set; } = null!;
    public Profesor Profesor { get; set; } = null!;
    public Aula? Aula { get; set; }
}
