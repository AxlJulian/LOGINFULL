using Contracts;
using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Docente;

namespace Shared.DataTransferObjects;

public record DocenteForUpdateDto(
    string Nombres,
    string Apellidos,
    DateTime FechaNacimiento,
    string Genero,
    string Direccion,
    string CorreoElectronico,
    string TituloAcademico,
    string NumeroTelefono,
    DateTime FechaContratacion,
    string EstadoLaboral,
    string NumeroIdentificacion,
    string ComentariosNotas,
    string NivelExperiencia,
    ICollection<Guid>? CursoId,
    ICollection<Guid>? MateriaId,
    Guid? HorarioId,
    Guid? AulaId
);

public static class DocenteMapper
{
    public static Docente MapToDocente(DocenteForUpdateDto dto, IMateriaRepository materiaRepository)
    {
        return new Docente
        {
            // Asignar las propiedades básicas
            Nombres = dto.Nombres,
            Apellidos = dto.Apellidos,
            FechaNacimiento = dto.FechaNacimiento,
            Genero = dto.Genero,
            Direccion = dto.Direccion,
            CorreoElectronico = dto.CorreoElectronico,
            TituloAcademico= dto.TituloAcademico,
            NumeroTelefono = dto.NumeroTelefono,
            FechaContratacion = dto.FechaContratacion,
            EstadoLaboral = dto.EstadoLaboral,
            NumeroIdentificacion = dto.NumeroIdentificacion,
            ComentariosNotas = dto.ComentariosNotas,
            NivelExperiencia = dto.NivelExperiencia,
        };
    }
}
