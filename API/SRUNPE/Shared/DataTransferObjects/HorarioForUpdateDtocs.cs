using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Docente;
using Entities.Models.D_Estudiante;

namespace Shared.DataTransferObjects
{
    public record HorarioForUpdateDto
    (
        string DiaSemana,
        TimeSpan? HoraInicio,
        TimeSpan? HoraFin,
        string PeriodoAcademico,
        string GrupoSeccion,
        DateTime FechaInicioClases,
        DateTime FechaFinClases,
        string EstadoHorario,
        int DuracionClaseMinutos,
        string NotificacionCambioHorario,

        string? DocenteNombre
    );

    public static class HorarioMapper
    {
        public static Horarios MapToHorario(HorarioForUpdateDto dto)
        {
            return new Horarios
            {
                DiaSemana = dto.DiaSemana,
                HoraInicio = (TimeSpan)dto.HoraInicio,
                HoraFin = (TimeSpan)dto.HoraFin,
                PeriodoAcademico = dto.PeriodoAcademico,
                GrupoSeccion = dto.GrupoSeccion,
                FechaInicioClases = dto.FechaInicioClases,
                FechaFinClases = dto.FechaFinClases,
                EstadoHorario = dto.EstadoHorario,
                DuracionClaseMinutos = dto.DuracionClaseMinutos,
                NotificacionCambioHorario = dto.NotificacionCambioHorario,
                Docente = new Docente { Nombres = dto.DocenteNombre }
            };
        }
    }
}
