namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Tabla intermedia: relación entre Profesor y Asignatura
/// Un profesor puede impartir varias asignaturas (máx 2)
/// Una asignatura puede ser impartida por varios profesores
/// </summary>
public class ProfesorAsignatura : EntidadBase
{
    public int ProfesorId { get; set; }
    public int AsignaturaId { get; set; }
    
    // Navegación
    public Profesor Profesor { get; set; } = null!;
    public Asignatura Asignatura { get; set; } = null!;
}
