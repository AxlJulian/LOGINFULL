namespace Shared.DataTransferObjects;

public record CandidatoEstudianteForCreationDto
(
    string Nombre,
    string Apellido,
    DateTime? FechaNacimiento,
    string TipoPersona,
    string TipoDocumento,
    long NumeroDocumento,
    long NumeroContacto,
    string Direccion,
    string Genero,
    string AdjuntarDocumentos,

    long NumeroIdentificacionAcudiente
);
