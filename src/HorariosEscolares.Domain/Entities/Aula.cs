namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Aula o salón del centro educativo
/// </summary>
public class Aula : EntidadBase
{
    public string Nombre { get; set; } = string.Empty;
    public string? Codigo { get; set; }
    public int Capacidad { get; set; } = 30;
    public bool Disponible { get; set; } = true;
    
    // Navegación
    public ICollection<AsignacionPeriodo> Asignaciones { get; set; } = new List<AsignacionPeriodo>();
}
