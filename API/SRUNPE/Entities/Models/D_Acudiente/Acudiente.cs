using Entities.Models.D_Estudiante;

namespace Entities.Models.D_Acudiente;

public partial class Acudiente
{
    public Guid AcudienteId { get; set; }
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public int NumeroIdentificacion { get; set; }
    public int Edad { get; set; }
    public string? CorreoElectronico { get; set; }
    public string? RelacionConEstudiante { get; set; }
    public string? EstadoCivil { get; set; }
    public string? Ocupacion { get; set; }
    public DateTime? FechaRegistro { get; set; }

    // Propiedades de navegación

    public long NumeroIdentificacionEstudiante { get; set; } // Cambio de nombre
    public ICollection<CandidatoEstudiante> CandidatoEstudiantes { get; set; }

    // Propiedad de navegación para la dirección
    public DireccionAcudiente DireccionAcudiente { get; set; }

    // Propiedad de navegación para los teléfonos
    public ICollection<TelefonoAcudiente> TelefonosAcudiente { get; set; }
}
