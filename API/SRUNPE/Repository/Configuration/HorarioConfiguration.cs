using System;
using Entities.Models.D_DepartamentoAcademico;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class HorarioConfiguration : IEntityTypeConfiguration<Horarios>
{
    public void Configure(EntityTypeBuilder<Horarios> builder)
    {
        builder.HasData(
        new Horarios
        {
            HorarioId = new Guid("17793c65-0075-4b33-f071-f84a0774be25"),
            DiaSemana = "Lunes",
            HoraInicio = TimeSpan.Parse("09:00:00"),
            HoraFin = TimeSpan.Parse("11:00:00"),
            PeriodoAcademico = "Semestre de Otoño",
            GrupoSeccion = "Grupo A",
            FechaInicioClases = new DateTime(2023, 09, 05),
            FechaFinClases = new DateTime(2023, 12, 15),
            EstadoHorario = "Activo",
            DuracionClaseMinutos = 120,
            NotificacionCambioHorario = "No"
        },
        new Horarios
        {
            HorarioId = new Guid("75acf5e1-58d1-43e5-2385-76f0a8f0f464"),
            DiaSemana = "Martes",
            HoraInicio = TimeSpan.Parse("14:00:00"),
            HoraFin = TimeSpan.Parse("16:00:00"),
            PeriodoAcademico = "Semestre de Primavera",
            GrupoSeccion = "Grupo B",
            FechaInicioClases = new DateTime(2023, 01, 10),
            FechaFinClases = new DateTime(2023, 04, 25),
            EstadoHorario = "Activo",
            DuracionClaseMinutos = 120,
            NotificacionCambioHorario = "Sí"
        }
    );
    }
}


