using AutoMapper;
using Entities.Models;
using Entities.Models.D_Acudiente;
using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Docente;
using Entities.Models.D_Estudiante;
using Entities.Models.D_Notas;
using Microsoft.AspNetCore.Routing.Constraints;
using Shared.DataTransferObjects;

namespace CompanyEmployees;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CandidatoEstudianteForUpdateDto, CandidatoEstudiante>();
        CreateMap<CandidatoEstudiante, CandidatoEstudianteDto>()
            .ForMember(dest => dest.CandidatoEstudianteId, opt => opt.MapFrom(src => src.CandidatoEstudianteId))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.Apellido, opt => opt.MapFrom(src => src.Apellido))
            .ForMember(dest => dest.FechaNacimiento, opt => opt.MapFrom(src => src.FechaNacimiento))
            .ForMember(dest => dest.TipoPersona, opt => opt.MapFrom(src => src.TipoPersona))
            .ForMember(dest => dest.TipoDocumento, opt => opt.MapFrom(src => src.TipoDocumento))
            .ForMember(dest => dest.NumeroDocumento, opt => opt.MapFrom(src => src.NumeroDocumento))
            .ForMember(dest => dest.NumeroContacto, opt => opt.MapFrom(src => src.NumeroContacto))
            .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
            .ForMember(dest => dest.Genero, opt => opt.MapFrom(src => src.Genero))
            .ForMember(dest => dest.AdjuntarDocumentos, opt => opt.MapFrom(src => src.AdjuntarDocumentos))

            .ForMember(dest => dest.NumeroIdentificacionAcudiente, opt => opt.MapFrom(src => src.NumeroIdentificacionAcudiente))
            .ForMember(dest => dest.Acudientes, opt => opt.Ignore())
            .ForMember(dest => dest.Acudientes, opt => opt.MapFrom(src => src.Acudientes.Select(a => a.Nombres)));

        CreateMap<AcudienteForUpdateDto, Acudiente>()
        .ForMember(dest => dest.DireccionAcudiente, opt => opt.Ignore());
        CreateMap<Acudiente, AcudienteDto>()
            .ForMember(dest => dest.AcudienteId, opt => opt.MapFrom(src => src.AcudienteId))
            .ForMember(dest => dest.Nombres, opt => opt.MapFrom(src => src.Nombres))
            .ForMember(dest => dest.Apellidos, opt => opt.MapFrom(src => src.Apellidos))
            .ForMember(dest => dest.NumeroIdentificacion, opt => opt.MapFrom(src => src.NumeroIdentificacion))
            .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico))
            .ForMember(dest => dest.RelacionConEstudiante, opt => opt.MapFrom(src => src.RelacionConEstudiante))
            .ForMember(dest => dest.EstadoCivil, opt => opt.MapFrom(src => src.EstadoCivil))
            .ForMember(dest => dest.Ocupacion, opt => opt.MapFrom(src => src.Ocupacion))
            .ForMember(dest => dest.Edad, opt => opt.MapFrom(src => src.Edad))
            .ForMember(dest => dest.FechaRegistro, opt => opt.MapFrom(src => src.FechaRegistro))

            .ForMember(dest => dest.NumeroIdentificacionEstudiante, opt => opt.MapFrom(src => src.NumeroIdentificacionEstudiante));

        CreateMap<EstudianteDocumentosForUpdateDto, EstudianteDocumentos>();
                CreateMap<EstudianteDocumentos, EstudianteDocumentosDto>()
                    .ForMember(dest => dest.EstudianteDocumentosId, opt => opt.MapFrom(src => src.EstudianteDocumentosId))
                    .ForMember(dest => dest.NombreDocumento, opt => opt.MapFrom(src => src.NombreDocumento))
                    .ForMember(dest => dest.TipoDocumento, opt => opt.MapFrom(src => src.TipoDocumento))
                    .ForMember(dest => dest.NumeroDocumento, opt => opt.MapFrom(src => src.NumeroDocumento))
                    .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
                    .ForMember(dest => dest.Observaciones, opt => opt.MapFrom(src => src.Observaciones))
                    .ForMember(dest => dest.FechaActualizacion, opt => opt.MapFrom(src => src.FechaActualizacion))
                    .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
                    .ForMember(dest => dest.Tamaño, opt => opt.MapFrom(src => src.Tamaño));

        // Mapeo para TelefonoAcudiente
        CreateMap<TelefonoAcudienteForUpdateDto, TelefonoAcudiente>();
        CreateMap<TelefonoAcudiente, TelefonoAcudienteDto>()
            .ForMember(dest => dest.TelefonoAcudienteId, opt => opt.MapFrom(src => src.TelefonoAcudienteId))
            .ForMember(dest => dest.Numero, opt => opt.MapFrom(src => src.Numero))
            .ForMember(dest => dest.Tipo, opt => opt.MapFrom(src => src.Tipo))
            .ForMember(dest => dest.Indicativo, opt => opt.MapFrom(src => src.Indicativo))
            .ForMember(dest => dest.AcudienteId, opt => opt.MapFrom(src => src.AcudienteId));

        // Mapeo para DireccionAcudiente
        CreateMap<DireccionAcudienteForUpdateDto, DireccionAcudiente>();
        CreateMap<DireccionAcudiente, DireccionAcudienteDto>()
            .ForMember(dest => dest.DireccionAcudienteId, opt => opt.MapFrom(src => src.DireccionAcudienteId))
            .ForMember(dest => dest.Calle, opt => opt.MapFrom(src => src.Calle))
            .ForMember(dest => dest.ColoniaBarrio, opt => opt.MapFrom(src => src.ColoniaBarrio))
            .ForMember(dest => dest.CiudadLocalidad, opt => opt.MapFrom(src => src.CiudadLocalidad))
            .ForMember(dest => dest.CodigoPostal, opt => opt.MapFrom(src => src.CodigoPostal))
            .ForMember(dest => dest.EstadoProvincia, opt => opt.MapFrom(src => src.EstadoProvincia))
            .ForMember(dest => dest.Pais, opt => opt.MapFrom(src => src.Pais))
            .ForMember(dest => dest.AcudienteId, opt => opt.MapFrom(src => src.AcudienteId));

        CreateMap<CupoForUpdateDto, Cupo>();
        CreateMap<Cupo, CupoDto>()
            .ForMember(dest => dest.CupoId, opt => opt.MapFrom(src => src.CupoId))
            .ForMember(dest => dest.CantidadDisponible, opt => opt.MapFrom(src => src.CantidadDisponible))
            .ForMember(dest => dest.FechaInicio, opt => opt.MapFrom(src => src.FechaInicio))
            .ForMember(dest => dest.FechaFin, opt => opt.MapFrom(src => src.FechaFin))
            .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
            .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
            .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
            .ForMember(dest => dest.Duracion, opt => opt.MapFrom(src => src.Duracion));
            //.ForMember(dest => dest.CandidatoEstudianteId, opt => opt.MapFrom(src => src.CandidatoEstudianteId))
            //.ForMember(dest => dest.Comentarios, opt => opt.MapFrom(src => src.Comentarios));

        CreateMap<RespuestaCupoForUpdateDto, RespuestaCupo>();
        CreateMap<RespuestaCupo, RespuestaCupoDto>()
            .ForMember(dest => dest.RespuestaCupoId, opt => opt.MapFrom(src => src.RespuestaCupoId))
            .ForMember(dest => dest.FechaRespuesta, opt => opt.MapFrom(src => src.FechaRespuesta))
            .ForMember(dest => dest.EstadoRespuesta, opt => opt.MapFrom(src => src.EstadoRespuesta))
            .ForMember(dest => dest.MensajeRespuesta, opt => opt.MapFrom(src => src.MensajeRespuesta))
            .ForMember(dest => dest.FechaVencimiento, opt => opt.MapFrom(src => src.FechaVencimiento))
            .ForMember(dest => dest.UsuarioRespuesta, opt => opt.MapFrom(src => src.UsuarioRespuesta))
            .ForMember(dest => dest.TipoRespuesta, opt => opt.MapFrom(src => src.TipoRespuesta))
            .ForMember(dest => dest.DuracionRespuesta, opt => opt.MapFrom(src => src.DuracionRespuesta))
            .ForMember(dest => dest.Prioridad, opt => opt.MapFrom(src => src.Prioridad));

        CreateMap<MatriculaForUpdateDto, Matricula>();
        CreateMap<Matricula, MatriculaDto>()
            .ForMember(dest => dest.MatriculaId, opt => opt.MapFrom(src => src.MatriculaId))
            .ForMember(dest => dest.FechaMatricula, opt => opt.MapFrom(src => src.FechaMatricula))
            .ForMember(dest => dest.EstadoMatricula, opt => opt.MapFrom(src => src.EstadoMatricula))
            .ForMember(dest => dest.TipoMatricula, opt => opt.MapFrom(src => src.TipoMatricula))
            .ForMember(dest => dest.PeriodoAcademico, opt => opt.MapFrom(src => src.PeriodoAcademico))
            .ForMember(dest => dest.Comentarios, opt => opt.MapFrom(src => src.Comentarios))
            .ForMember(dest => dest.CategoriaMatricula, opt => opt.MapFrom(src => src.CategoriaMatricula))
            .ForMember(dest => dest.InformacionPlanEstudios, opt => opt.MapFrom(src => src.InformacionPlanEstudios))
            .ForMember(dest => dest.RegistroCambios, opt => opt.MapFrom(src => src.RegistroCambios));

        CreateMap<PreMatriculaForUpdateDto, PreMatricula>();
        CreateMap<PreMatricula, PreMatriculaDto>()
            .ForMember(dest => dest.PreMatriculaId, opt => opt.MapFrom(src => src.PreMatriculaId))
            .ForMember(dest => dest.GradoONivel, opt => opt.MapFrom(src => src.GradoONivel))
            .ForMember(dest => dest.Turno, opt => opt.MapFrom(src => src.Turno))
            .ForMember(dest => dest.Observaciones, opt => opt.MapFrom(src => src.Observaciones))
            .ForMember(dest => dest.EstadoPreMatricula, opt => opt.MapFrom(src => src.EstadoPreMatricula))
            .ForMember(dest => dest.RequisitosDocumentacion, opt => opt.MapFrom(src => src.RequisitosDocumentacion));

        CreateMap<AulaForUpdateDto, Aulas>();
        CreateMap<Aulas, AulaDto>()
            .ForMember(dest => dest.AulaId, opt => opt.MapFrom(src => src.AulaId))
            .ForMember(dest => dest.NombreNumero, opt => opt.MapFrom(src => src.NombreNumero))
            .ForMember(dest => dest.Ubicacion, opt => opt.MapFrom(src => src.Ubicacion))
            .ForMember(dest => dest.Capacidad, opt => opt.MapFrom(src => src.Capacidad))
            .ForMember(dest => dest.TipoAula, opt => opt.MapFrom(src => src.TipoAula))
            .ForMember(dest => dest.EstadoAula, opt => opt.MapFrom(src => src.EstadoAula))
            .ForMember(dest => dest.HorarioDisponibilidad, opt => opt.MapFrom(src => src.HorarioDisponibilidad))
            .ForMember(dest => dest.NotasAdicionales, opt => opt.MapFrom(src => src.NotasAdicionales))
            .ForMember(dest => dest.UltimaActualizacion, opt => opt.MapFrom(src => src.UltimaActualizacion))
            .ForMember(dest => dest.RegistrosIncidentesProblemas, opt => opt.MapFrom(src => src.RegistrosIncidentesProblemas));

        CreateMap<CursoForUpdateDto, Cursos>();
        CreateMap<Cursos, CursoDto>()
            .ForMember(dest => dest.CursoId, opt => opt.MapFrom(src => src.CursoId))
            .ForMember(dest => dest.CodigoCurso, opt => opt.MapFrom(src => src.CodigoCurso))
            .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
            .ForMember(dest => dest.DepartamentoAcademico, opt => opt.MapFrom(src => src.DepartamentoAcademico))
            .ForMember(dest => dest.Nivel, opt => opt.MapFrom(src => src.Nivel))
            .ForMember(dest => dest.MetodosEnsenanza, opt => opt.MapFrom(src => src.MetodosEnsenanza))
            .ForMember(dest => dest.Año, opt => opt.MapFrom(src => src.Año))
            .ForMember(dest => dest.CupoActual, opt => opt.MapFrom(src => src.CupoActual))
            .ForMember(dest => dest.CupoMaximo, opt => opt.MapFrom(src => src.CupoMaximo))
            .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
            .ForMember(dest => dest.Modalidad, opt => opt.MapFrom(src => src.Modalidad))
            .ForMember(dest => dest.FechaFinalizacion, opt => opt.MapFrom(src => src.FechaFinalizacion))
            .ForMember(dest => dest.FechaInicio, opt => opt.MapFrom(src => src.FechaInicio));


    CreateMap<HorarioForUpdateDto, Horarios>();
            //.ForMember(dest => dest.Docente, opt => opt.MapFrom(src => new Docente { Nombres = src.DocenteNombre }));
        CreateMap<Horarios, HorarioDto>()
            .ForMember(dest => dest.HorarioId, opt => opt.MapFrom(src => src.HorarioId))
            .ForMember(dest => dest.DiaSemana, opt => opt.MapFrom(src => src.DiaSemana))
            .ForMember(dest => dest.HoraInicio, opt => opt.MapFrom(src => src.HoraInicio))
            .ForMember(dest => dest.HoraFin, opt => opt.MapFrom(src => src.HoraFin))
            .ForMember(dest => dest.PeriodoAcademico, opt => opt.MapFrom(src => src.PeriodoAcademico))
            .ForMember(dest => dest.GrupoSeccion, opt => opt.MapFrom(src => src.GrupoSeccion))
            .ForMember(dest => dest.FechaInicioClases, opt => opt.MapFrom(src => src.FechaInicioClases))
            .ForMember(dest => dest.FechaFinClases, opt => opt.MapFrom(src => src.FechaFinClases))
            .ForMember(dest => dest.EstadoHorario, opt => opt.MapFrom(src => src.EstadoHorario))
            .ForMember(dest => dest.DuracionClaseMinutos, opt => opt.MapFrom(src => src.DuracionClaseMinutos))
            .ForMember(dest => dest.NotificacionCambioHorario, opt => opt.MapFrom(src => src.NotificacionCambioHorario));


        CreateMap<MateriaForUpdateDto, Materias>();
            //.ForMember(dest => dest.Docentes, opt => opt.MapFrom(src => new List<Docente> { new Docente { Nombres = src.DocenteNombre } }));
        CreateMap<Materias, MateriaDto>()
            .ForMember(dest => dest.MateriaId, opt => opt.MapFrom(src => src.MateriaId))
            .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
            .ForMember(dest => dest.Descripcion, opt => opt.MapFrom(src => src.Descripcion))
            .ForMember(dest => dest.DepartamentoAcademico, opt => opt.MapFrom(src => src.DepartamentoAcademico))
            .ForMember(dest => dest.Nivel, opt => opt.MapFrom(src => src.Nivel))
            .ForMember(dest => dest.Creditos, opt => opt.MapFrom(src => src.Creditos))
            .ForMember(dest => dest.Estado, opt => opt.MapFrom(src => src.Estado))
            .ForMember(dest => dest.NotasAdicionales, opt => opt.MapFrom(src => src.NotasAdicionales))
            .ForMember(dest => dest.MetodosEnsenanza, opt => opt.MapFrom(src => src.MetodosEnsenanza))
            .ForMember(dest => dest.HorasPracticas, opt => opt.MapFrom(src => src.HorasPracticas))
            .ForMember(dest => dest.HorasTeoricas, opt => opt.MapFrom(src => src.HorasTeoricas));

        CreateMap<DocenteForUpdateDto, Docente>();
        CreateMap<Docente, DocenteDto>()
            .ForMember(dest => dest.DocenteId, opt => opt.MapFrom(src => src.DocenteId))
            .ForMember(dest => dest.Nombres, opt => opt.MapFrom(src => src.Nombres))
            .ForMember(dest => dest.Apellidos, opt => opt.MapFrom(src=>src.Apellidos))
            .ForMember(dest => dest.FechaNacimiento, opt => opt.MapFrom(src => src.FechaNacimiento))
            .ForMember(dest => dest.Genero, opt => opt.MapFrom(src => src.Genero))
            .ForMember(dest => dest.Direccion, opt => opt.MapFrom(src => src.Direccion))
            .ForMember(dest => dest.CorreoElectronico, opt => opt.MapFrom(src => src.CorreoElectronico))
            .ForMember(dest => dest.TituloAcademico, opt => opt.MapFrom(src => src.TituloAcademico))
            .ForMember(dest => dest.NumeroTelefono, opt => opt.MapFrom(src => src.NumeroTelefono))
            .ForMember(dest => dest.FechaContratacion, opt => opt.MapFrom(src => src.FechaContratacion))
            .ForMember(dest => dest.EstadoLaboral, opt => opt.MapFrom(src => src.EstadoLaboral))
            .ForMember(dest => dest.NumeroIdentificacion, opt => opt.MapFrom(src => src.NumeroIdentificacion))
            .ForMember(dest => dest.ComentariosNotas, opt => opt.MapFrom(src => src.ComentariosNotas))
            .ForMember(dest => dest.NivelExperiencia, opt => opt.MapFrom(src => src.NivelExperiencia))

            .ForMember(dest => dest.Cursos, opt => opt.MapFrom(src => src.Cursos))
            .ForMember(dest => dest.Materias, opt => opt.MapFrom(src => src.Materias))
            .ForMember(dest => dest.HorarioId, opt => opt.MapFrom(src => src.HorarioId))
            .ForMember(dest => dest.AulaId, opt => opt.MapFrom(src => src.AulaId))


            .ForMember(dest => dest.DiaSemana, opt => opt.MapFrom(src => src.Horario.DiaSemana))
            .ForMember(dest => dest.NombreNumero, opt => opt.MapFrom(src => src.Aula.NombreNumero));


        CreateMap<EstadisticaForUpdateDto, Estadisticas>();
        CreateMap<Estadisticas, EstadisticaDto>()
            .ForMember(dest => dest.EstadisticaId, opt => opt.MapFrom(src => src.EstadisticaId))
            .ForMember(dest => dest.Materia, opt => opt.MapFrom(src => src.Materia))
            .ForMember(dest => dest.NotaPromedio, opt => opt.MapFrom(src => src.NotaPromedio))
            .ForMember(dest => dest.NotaMaxima, opt => opt.MapFrom(src => src.NotaMaxima))
            .ForMember(dest => dest.NotaMinima, opt => opt.MapFrom(src => src.NotaMinima))
            .ForMember(dest => dest.CantidadExamenes, opt => opt.MapFrom(src => src.CantidadExamenes))
            .ForMember(dest => dest.FechaRegistro, opt => opt.MapFrom(src => src.FechaRegistro))
            .ForMember(dest => dest.AñoEscolar, opt => opt.MapFrom(src => src.AñoEscolar))
            .ForMember(dest => dest.PeriodoEscolar, opt => opt.MapFrom(src => src.PeriodoEscolar));

        

        CreateMap<NotaForUpdateDto, Notas>();
        CreateMap<Notas, NotaDto>()
            .ForMember(dest => dest.NotaId, opt => opt.MapFrom(src => src.NotaId))
            .ForMember(dest => dest.Curso, opt => opt.MapFrom(src => src.Curso))
            .ForMember(dest => dest.FechaCreacion, opt => opt.MapFrom(src => src.FechaCreacion))
            .ForMember(dest => dest.Materia, opt => opt.MapFrom(src => src.Materia))
            .ForMember(dest => dest.PeriodoAcademico, opt => opt.MapFrom(src => src.PeriodoAcademico))
            .ForMember(dest => dest.ValorNota, opt => opt.MapFrom(src => src.ValorNota))
            .ForMember(dest => dest.TipoNota, opt => opt.MapFrom(src => src.TipoNota))
            .ForMember(dest => dest.DescripcionNota, opt => opt.MapFrom(src => src.DescripcionNota));





        //MapCreate
        CreateMap<CandidatoEstudianteForCreationDto, CandidatoEstudiante>();
        CreateMap<AcudienteForCreationDto, Acudiente>();
        CreateMap<EstudianteDocumentosForCreationDto, EstudianteDocumentos>();
        CreateMap<TelefonoAcudienteForCreationDto, TelefonoAcudiente>();
        CreateMap<DireccionAcudienteForCreationDto, DireccionAcudiente>();
        CreateMap<CupoForCreationDto, Cupo>();
        CreateMap<RespuestaCupoForCreationDto, RespuestaCupo>();
        CreateMap<PreMatriculaForCreationDto, PreMatricula>();
        CreateMap<MatriculaForCreationDto, Matricula>();
        CreateMap<AulaForCreationDto,Aulas>();
        CreateMap<CursoForCreationDto, Cursos>();
        CreateMap<HorarioForCreationDto, Horarios>();
        CreateMap<MateriaForCreationDto, Materias>();
        CreateMap<EstadisticaForCreationDto, Estadisticas>();
        CreateMap<DocenteForCreationDto, Docente>();
        CreateMap<NotaForCreationDto, Notas>();

    }
}
