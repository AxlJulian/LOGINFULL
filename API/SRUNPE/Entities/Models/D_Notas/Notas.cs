using System.ComponentModel.DataAnnotations;

namespace Entities.Models.D_Notas;

public partial class Notas

{
    [Key]
    public int NotaId { get; set; }
    public string Estudiante { get; set; }
    public string Curso { get; set; }
    public string PeriodoAcademico { get; set; }
    public DateTime FechaCreacion { get; set; }
    public string Materia { get; set; }
    public int ValorNota { get; set; }
    public string TipoNota { get; set; }
    public string DescripcionNota { get; set; }

}
