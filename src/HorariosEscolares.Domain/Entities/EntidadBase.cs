namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Clase base para todas las entidades
/// </summary>
public abstract class EntidadBase
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedAt { get; set; }
}
