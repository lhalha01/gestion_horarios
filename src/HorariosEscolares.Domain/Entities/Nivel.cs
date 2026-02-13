namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Nivel educativo (1º, 2º, 3º)
/// </summary>
public class Nivel : EntidadBase
{
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public int Orden { get; set; }
    
    // Navegación
    public ICollection<Clase> Clases { get; set; } = new List<Clase>();
}
