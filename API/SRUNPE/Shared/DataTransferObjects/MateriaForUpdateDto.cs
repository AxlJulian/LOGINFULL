using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Docente;
using Entities.Models.D_Estudiante;


namespace Shared.DataTransferObjects
{
    public record MateriaForUpdateDto(string Nombre,
    string Descripcion,
    string DepartamentoAcademico,
    string Nivel,
    int Creditos,
    string Estado,
    string NotasAdicionales,
    string MetodosEnsenanza,
    int HorasTeoricas,
    int HorasPracticas,
    
    string? DocenteNombre
    );

    public static class MateriaEstudianteMapper
    {
        public static Materias MapToMateria(MateriaForUpdateDto dto)
        {
            return new Materias
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                DepartamentoAcademico=dto.DepartamentoAcademico,
                Nivel = dto.Nivel,
                Creditos=dto.Creditos,
                Estado=dto.Estado,
                NotasAdicionales=dto.NotasAdicionales,  
                MetodosEnsenanza=dto.MetodosEnsenanza,
                HorasPracticas=dto.HorasPracticas,
                HorasTeoricas=dto.HorasTeoricas,

                //Docentes = new List<Docente> { new Docente { Nombres = dto.DocenteNombre } }
            };
        }
    }
}