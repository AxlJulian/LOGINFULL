using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Docente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects;

public class AsignacionDocenteDto
{
    public Guid DocenteId { get; set; }
    public Guid MateriaId { get; set; }
    public Guid CursoId { get; set; }
}

