namespace Shared.DataTransferObjects;

public record NotaForCreationDto(
string Estudiante,
string Curso,
string PeriodoAcademico,
DateTime FechaCreacion,
string Materia,
int ValorNota,
string TipoNota,
string DescripcionNota);