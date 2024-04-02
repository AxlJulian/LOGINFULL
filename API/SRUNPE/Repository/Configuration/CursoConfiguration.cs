using Entities.Models.D_DepartamentoAcademico;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Models.D_Estudiante;

namespace Repository.Configuration;

public class CursoConfiguration : IEntityTypeConfiguration<Cursos>
{
    public void Configure(EntityTypeBuilder<Cursos> builder)
    {
        builder.HasData(
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                CodigoCurso = "MAT101",
                Descripcion = "Introducción a las Matemáticas",
                DepartamentoAcademico = "Matemáticas",
                Nivel = "Básico",
                MetodosEnsenanza = "Presencial",
                Año = 2024,
                CupoMaximo = 30,
                CupoActual = 25,
                Estado = "Activo",
                Modalidad = "Presencial",
                FechaInicio = new DateTime(2024, 2, 1),
                FechaFinalizacion = new DateTime(2024, 6, 30)
            },
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                CodigoCurso = "FIS102",
                Descripcion = "Física General",
                DepartamentoAcademico = "Ciencias Físicas",
                Nivel = "Intermedio",
                MetodosEnsenanza = "Virtual",
                Año = 2024,
                CupoMaximo = 40,
                CupoActual = 35,
                Estado = "Activo",
                Modalidad = "En línea",
                FechaInicio = new DateTime(2024, 3, 1),
                FechaFinalizacion = new DateTime(2024, 7, 30)
            },
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                CodigoCurso = "HIS103",
                Descripcion = "Historia del Mundo Contemporáneo",
                DepartamentoAcademico = "Historia",
                Nivel = "Avanzado",
                MetodosEnsenanza = "Híbrido",
                Año = 2024,
                CupoMaximo = 25,
                CupoActual = 20,
                Estado = "Activo",
                Modalidad = "Híbrido",
                FechaInicio = new DateTime(2024, 4, 1),
                FechaFinalizacion = new DateTime(2024, 8, 30)
            },
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                CodigoCurso = "LIT104",
                Descripcion = "Literatura Española",
                DepartamentoAcademico = "Literatura",
                Nivel = "Básico",
                MetodosEnsenanza = "Presencial",
                Año = 2024,
                CupoMaximo = 20,
                CupoActual = 18,
                Estado = "Activo",
                Modalidad = "Presencial",
                FechaInicio = new DateTime(2024, 5, 1),
                FechaFinalizacion = new DateTime(2024, 9, 30)
            }, 
            new Cursos
            {
                CursoId = Guid.NewGuid(),
                CodigoCurso = "QUI105",
                Descripcion = "Química Orgánica",
                DepartamentoAcademico = "Química",
                Nivel = "Intermedio",
                MetodosEnsenanza = "Virtual",
                Año = 2024,
                CupoMaximo = 35,
                CupoActual = 30,
                Estado = "Activo",
                Modalidad = "En línea",
                FechaInicio = new DateTime(2024, 6, 1),
                FechaFinalizacion = new DateTime(2024, 10, 30)
            }
        );
    }
}


