namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Horario semanal completo del centro educativo
/// </summary>
public class Horario : EntidadBase
{
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime? FechaFin { get; set; }
    public bool Activo { get; set; } = true;
    public bool Aprobado { get; set; } = false;
    public int? AprobadoPorUsuarioId { get; set; }
    public DateTime? FechaAprobacion { get; set; }
    
    // Navegación
    public Usuario? AprobadoPor { get; set; }
    public ICollection<AsignacionPeriodo> Asignaciones { get; set; } = new List<AsignacionPeriodo>();
}
