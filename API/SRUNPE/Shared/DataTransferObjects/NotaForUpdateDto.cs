using Entities.Models.D_Notas;

namespace Shared.DataTransferObjects;

public record NotaForUpdateDto(
        string Estudiante,
        string Curso,
        string PeriodoAcademico,
        DateTime FechaCreacion,
        string Materia,
        int ValorNota,
        string TipoNota,
        string DescripcionNota);
public static class NotaMapper { 
    public static Notas MapToNotas(NotaForUpdateDto dto)
    {
        return new Notas
        {
            Estudiante = dto.Estudiante,
            Curso = dto.Curso,
            FechaCreacion = dto.FechaCreacion,
            Materia = dto.Materia,
            PeriodoAcademico = dto.PeriodoAcademico,
            ValorNota = dto.ValorNota,
            TipoNota = dto.TipoNota,
            DescripcionNota = dto.DescripcionNota
        };
    }

}
