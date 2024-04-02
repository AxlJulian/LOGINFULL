using Entities.Models.D_Docente;

namespace Entities.Models.D_DepartamentoAcademico;

public partial class Aulas
{
    public Guid AulaId { get; set; }
    public string NombreNumero { get; set; }
    public string Ubicacion { get; set; }
    public int Capacidad { get; set; }
    public string TipoAula { get; set; }
    public string EstadoAula { get; set; }
    public string HorarioDisponibilidad { get; set; }
    public string NotasAdicionales { get; set; }
    public DateTime UltimaActualizacion { get; set; }
    public string RegistrosIncidentesProblemas { get; set; }

    public Guid DocenteId { get; set; } // FK de Docente
    public Docente Docente { get; set; }

}
