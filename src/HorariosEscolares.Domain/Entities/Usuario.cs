using HorariosEscolares.Domain.Enums;

namespace HorariosEscolares.Domain.Entities;

/// <summary>
/// Usuario del sistema
/// </summary>
public class Usuario : EntidadBase
{
    public string NombreCompleto { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public Rol Rol { get; set; }
    public bool Activo { get; set; } = true;
    public DateTime? UltimoAcceso { get; set; }
}
