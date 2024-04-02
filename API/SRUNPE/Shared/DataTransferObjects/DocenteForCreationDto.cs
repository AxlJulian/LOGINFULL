namespace Shared.DataTransferObjects;

public record DocenteForCreationDto(
    string Nombres,
    string Apellidos,
    DateTime? FechaNacimiento,
    string Genero,
    string Direccion,
    string CorreoElectronico,
    string TituloAcademico,
    string NumeroTelefono,
    DateTime? FechaContratacion,
    string EstadoLaboral,
    string NumeroIdentificacion,
    string ComentariosNotas,
    string NivelExperiencia,
    ICollection<Guid>? CursoId,   // Opcional
    ICollection<Guid>? MateriaId, // Opcional
    Guid? HorarioId,              // Opcional
    Guid? AulaId                  // Opcional
);

