using Entities.Models.D_Acudiente;
using Entities.Models.D_Docente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Repository.Configuration
{
    internal class DocenteConfiguration : IEntityTypeConfiguration<Docente>
    {
        public void Configure(EntityTypeBuilder<Docente> builder)

        {

            builder.HasData(

            new Docente
            {
                DocenteId = Guid.NewGuid(),
                Nombres = "Juan",
                Apellidos = "Pérez",
                FechaNacimiento = new DateTime(1980, 5, 15),
                Genero = "Masculino",
                Direccion = "Calle Falsa 123",
                CorreoElectronico = "juan.perez@email.com",
                TituloAcademico = "Licenciado en Matemáticas",
                NumeroTelefono = "555-1234",
                FechaContratacion = new DateTime(2010, 8, 1),
                EstadoLaboral = "Activo",
                NumeroIdentificacion = "12345678",
                ComentariosNotas = "Excelente capacidad de enseñanza",
                NivelExperiencia = "Alto"
            },

            new Docente
            {
                DocenteId = Guid.NewGuid(),
                Nombres = "María",
                Apellidos = "González",
                FechaNacimiento = new DateTime(1985, 3, 20),
                Genero = "Femenino",
                Direccion = "Avenida Principal 456",
                CorreoElectronico = "maria.gonzalez@email.com",
                TituloAcademico = "Doctora en Historia",
                NumeroTelefono = "555-5678",
                FechaContratacion = new DateTime(2012, 9, 15),
                EstadoLaboral = "Activo",
                NumeroIdentificacion = "87654321",
                ComentariosNotas = "Experta en historia antigua",
                NivelExperiencia = "Medio"
            },
            new Docente
            {
                DocenteId = Guid.NewGuid(),
                Nombres = "Carlos",
                Apellidos = "Martínez",
                FechaNacimiento = new DateTime(1975, 11, 30),
                Genero = "Masculino",
                Direccion = "Boulevard del Río 789",
                CorreoElectronico = "carlos.martinez@email.com",
                TituloAcademico = "Magíster en Física",
                NumeroTelefono = "555-9101",
                FechaContratacion = new DateTime(2008, 2, 20),
                EstadoLaboral = "Inactivo",
                NumeroIdentificacion = "11223344",
                ComentariosNotas = "Gran habilidad en experimentos prácticos",
                NivelExperiencia = "Alto"
            },
            new Docente
            {
                DocenteId = Guid.NewGuid(),
                Nombres = "Laura",
                Apellidos = "Rodríguez",
                FechaNacimiento = new DateTime(1990, 7, 10),
                Genero = "Femenino",
                Direccion = "Callejón de los Milagros 101",
                CorreoElectronico = "laura.rodriguez@email.com",
                TituloAcademico = "Licenciada en Biología",
                NumeroTelefono = "555-1213",
                FechaContratacion = new DateTime(2015, 5, 25),
                EstadoLaboral = "Activo",
                NumeroIdentificacion = "44332211",
                ComentariosNotas = "Especialista en biología marina",
                NivelExperiencia = "Bajo"
            }
        );
        }
    }
}
