namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Clase o grupo dentro de un nivel (A, B, C)
/// </summary>
public class Clase : EntidadBase
{
    public string Nombre { get; set; } = string.Empty; // A, B, C
    public int NivelId { get; set; }
    public int CantidadAlumnos { get; set; } = 25;
    
    // Navegación
    public Nivel Nivel { get; set; } = null!;
    public ICollection<AsignacionPeriodo> Asignaciones { get; set; } = new List<AsignacionPeriodo>();
}
