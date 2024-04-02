using Entities.Models.D_Estudiante;

namespace Shared.DataTransferObjects;

public class AcudienteDto
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

    public long NumeroIdentificacionEstudiante { get; set; } // Cambio de nombre
    public ICollection<CandidatoEstudiante> CandidatoEstudiantes { get; set; }

    public ICollection<TelefonoAcudienteDto>? TelefonosAcudiente { get; set; }
    public DireccionAcudienteDto? DireccionAcudiente { get; set; }
}