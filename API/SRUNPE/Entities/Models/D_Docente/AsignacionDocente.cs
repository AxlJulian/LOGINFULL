using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Estudiante;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.D_Docente;

public class AsignacionDocente
{
    public int Id { get; set; }
    public Guid DocenteId { get; set; }
    public Docente Docente { get; set; }
    public Guid MateriaId { get; set; }
    public Materias Materia { get; set; }
    public Guid CursoId { get; set; }
    public Cursos Curso { get; set; }
}

