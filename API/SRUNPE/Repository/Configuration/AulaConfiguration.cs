using Entities.Models.D_DepartamentoAcademico;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace Repository.Configuration;

public class AulaConfiguration : IEntityTypeConfiguration<Aulas>
{
    public void Configure(EntityTypeBuilder<Aulas> builder)
    {

        builder.HasData(
            new Aulas
            {
                AulaId = new Guid("bd249220-eec2-4bbd-c57e-8619cb666ece"),
                NombreNumero = "Aula 101",
                Ubicacion = "Edificio Principal",
                Capacidad = 50,
                TipoAula = "Salón de Clases",
                EstadoAula = "Disponible",
                HorarioDisponibilidad = "Lunes a Viernes, 08:00 AM - 06:00 PM",
                NotasAdicionales = "Equipada con proyector",
                UltimaActualizacion = new DateTime(2023, 09, 15),
                RegistrosIncidentesProblemas = "Ninguno",
            },
            new Aulas
            {
                AulaId = new Guid("53c29e9a-f7b8-433b-983f-a85b823c4733"),
                NombreNumero = "Aula 102",
                Ubicacion = "Edificio de Ciencias",
                Capacidad = 30,
                TipoAula = "Laboratorio de Informática",
                EstadoAula = "Ocupado",
                HorarioDisponibilidad = "Lunes a Viernes, 10:00 AM - 05:00 PM",
                NotasAdicionales = "Equipado con computadoras de última generación",
                UltimaActualizacion = new DateTime(2023, 09, 10),
                RegistrosIncidentesProblemas = "Reporte de fallo en una computadora",
            }

        );

    }
}
