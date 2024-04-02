using Entities.Models.D_Docente;

namespace Entities.Models.D_DepartamentoAcademico;

public partial class Horarios
{
    public Guid HorarioId { get; set; }
    public string DiaSemana {  get; set; }
    public TimeSpan? HoraInicio { get; set; }
    public TimeSpan? HoraFin { get; set; }
    public string PeriodoAcademico { get; set; }
    public string GrupoSeccion { get; set; }
    public DateTime FechaInicioClases { get; set; }
    public DateTime FechaFinClases { get; set; }
    public string EstadoHorario { get; set; }
    public int DuracionClaseMinutos { get; set; }
    public string NotificacionCambioHorario{ get; set;}

    public Guid DocenteId { get; set; } // FK de Docente
    public Docente Docente { get; set; }

}
