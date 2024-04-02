using Entities.Models.D_DepartamentoAcademico;


namespace Shared.DataTransferObjects;

public record CursoForUpdateDto(
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

public static class CursoMapper
{
    public static Cursos MapToCurso(CursoForUpdateDto dto)
    {
        return new Cursos
        {
            CodigoCurso = dto.CodigoCurso,
            Descripcion = dto.Descripcion,
            DepartamentoAcademico= dto.DepartamentoAcademico,
            Nivel= dto.Nivel,
            MetodosEnsenanza= dto.MetodosEnsenanza,
            Año=dto.Año,
            CupoActual= dto.CupoActual,
            CupoMaximo= dto.CupoMaximo,
            Estado= dto.Estado,
            Modalidad= dto.Modalidad,
            FechaFinalizacion= dto.FechaFinalizacion,
            FechaInicio= dto.FechaInicio,
        };
    }
}