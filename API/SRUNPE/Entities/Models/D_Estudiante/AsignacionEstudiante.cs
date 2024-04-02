using Entities.Models.D_DepartamentoAcademico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.D_Estudiante;

public class AsignacionEstudiante
{
    public int Id { get; set; }
    public Guid CandidatoEstudianteId { get; set; }
    public CandidatoEstudiante CandidatoEstudiante { get; set; }
    public Guid CursoId { get; set; }
    public Cursos Cursos { get; set; }
    public Guid AulaId { get; set; }
    public Aulas Aulas { get; set; }
    public Guid HorarioId { get; set; }
    public Horarios Horarios { get; set; }
}
