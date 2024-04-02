namespace Shared.DataTransferObjects;

public record HorarioForCreationDto
(
    string DiaSemana,
    TimeSpan HoraInicio,
    TimeSpan HoraFin,
    string PeriodoAcademico,
    string GrupoSeccion,
    DateTime FechaInicioClases,
    DateTime FechaFinClases,
    string EstadoHorario,
    int DuracionClaseMinutos,
    string NotificacionCambioHorario,


    DocenteDto? Docente
    
);
