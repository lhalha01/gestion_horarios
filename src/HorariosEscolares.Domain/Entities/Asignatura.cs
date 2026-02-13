namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Asignatura o materia del plan de estudios
/// </summary>
public class Asignatura : EntidadBase
{
    public string Nombre { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public int HorasSemanales { get; set; }
    public string? Descripcion { get; set; }
    public string? Color { get; set; } // Para visualización en horarios
    
    // Navegación
    public ICollection<ProfesorAsignatura> ProfesoresAsignaturas { get; set; } = new List<ProfesorAsignatura>();
    public ICollection<AsignacionPeriodo> Asignaciones { get; set; } = new List<AsignacionPeriodo>();
}
