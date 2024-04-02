namespace Shared.DataTransferObjects;

public record AcudienteForCreationDto(
    string? Nombres,
    string? Apellidos,
    int NumeroIdentificacion,
    int Edad,
    string? CorreoElectronico,
    string? RelacionConEstudiante,
    string? EstadoCivil,
    string? Ocupacion,
    DateTime? FechaRegistro,

    long NumeroIdentificacionEstudiante, // Este campo se usará para relacionar con CandidatoEstudiante

    IEnumerable<TelefonoAcudienteForCreationDto>? TelefonosAcudiente,
    DireccionAcudienteForCreationDto? DireccionAcudiente
);

