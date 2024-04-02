using Entities.Models.D_Acudiente;

namespace Shared.DataTransferObjects;

public record AcudienteForUpdateDto(
    string? Nombres,
    string? Apellidos,
    int NumeroIdentificacion,
    int Edad,
    string? CorreoElectronico,
    string? RelacionConEstudiante,
    string? EstadoCivil,
    string? Ocupacion,
    DateTime? FechaRegistro,


    ICollection<string>? NombresEstudiantesRelacionados, // Lista de nombres de estudiantes relacionados
    ICollection<TelefonoAcudienteForUpdateDto>? TelefonosAcudiente,
    DireccionAcudienteForUpdateDto? DireccionAcudiente
)
{
    public static Acudiente MapToAcudiente(AcudienteForUpdateDto dto)
    {
        return new Acudiente
        {
            Nombres = dto.Nombres,
            Apellidos = dto.Apellidos,
            NumeroIdentificacion = dto.NumeroIdentificacion,
            Edad = dto.Edad,
            CorreoElectronico = dto.CorreoElectronico,
            RelacionConEstudiante = dto.RelacionConEstudiante,
            EstadoCivil = dto.EstadoCivil,
            Ocupacion = dto.Ocupacion,
            FechaRegistro = dto.FechaRegistro,
            TelefonosAcudiente = dto.TelefonosAcudiente?.Select(t => TelefonoAcudienteForUpdateDto.MapToTelefonoAcudiente(t)).ToList(),
            DireccionAcudiente = dto.DireccionAcudiente != null ? DireccionAcudienteForUpdateDto.MapToDireccionAcudiente(dto.DireccionAcudiente) : null
        };
    }
}
