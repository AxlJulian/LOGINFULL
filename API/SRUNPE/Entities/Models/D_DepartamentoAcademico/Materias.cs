using Entities.Models.D_Docente;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.D_DepartamentoAcademico;

public partial class Materias
{
    [Key]
    public Guid MateriaId { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string DepartamentoAcademico { get; set; }
    public string Nivel { get; set; }
    public int Creditos { get; set; }
    public string Estado { get; set; }
    public string NotasAdicionales { get; set; }
    public string MetodosEnsenanza { get; set; }
    public int HorasTeoricas { get; set; }
    public int HorasPracticas { get; set; }

    public ICollection<Docente>? Docentes { get; set; }

}
