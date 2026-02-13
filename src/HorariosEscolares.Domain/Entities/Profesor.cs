namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Profesor del centro educativo
/// </summary>
public class Profesor : EntidadBase
{
    public string NombreCompleto { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? Telefono { get; set; }
    public int MaxHorasSemanales { get; set; } = 20;
    public int MaxAsignaturas { get; set; } = 2;
    public bool Activo { get; set; } = true;
    
    // Navegación
    public ICollection<ProfesorAsignatura> ProfesoresAsignaturas { get; set; } = new List<ProfesorAsignatura>();
    public ICollection<AsignacionPeriodo> Asignaciones { get; set; } = new List<AsignacionPeriodo>();
}
