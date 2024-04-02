namespace Shared.DataTransferObjects;

public record CursoForCreationDto(
string CodigoCurso,
string Descripcion,
string DepartamentoAcademico,
string Nivel,
string MetodosEnsenanza,
int Año,
int CupoMaximo,
int CupoActual,
string Estado,
string Modalidad,
DateTime FechaInicio,
DateTime FechaFinalizacion);
