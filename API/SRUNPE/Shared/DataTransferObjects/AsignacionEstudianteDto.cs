using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects;

public class AsignacionEstudianteDto
{
    public Guid CandidatoEstudianteId { get; set; }
    public Guid CursoId { get; set; }
    public Guid AulaId { get; set; }
    public Guid HorarioId { get; set; }
}
