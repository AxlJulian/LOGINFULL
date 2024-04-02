using Entities.Models.D_Notas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    internal class NotaConfiguration : IEntityTypeConfiguration<Notas>
    {
        public void Configure(EntityTypeBuilder<Notas> builder)

        {
            builder.HasData(
            new Notas
            {
                NotaId = 1,
                Estudiante = "Juan Pérez",
                Curso = "Matemáticas",
                PeriodoAcademico = "Cuarto Periodo",
                FechaCreacion = DateTime.Now,
                Materia = "Álgebra",
                ValorNota = 85,
                TipoNota = "Examen",
                DescripcionNota = "Examen de mitad de periodo"
            },

            new Notas
            {
                NotaId = 2,
                Estudiante = "María López",
                Curso = "Ciencias",
                PeriodoAcademico = "Primer Periodo",
                FechaCreacion = DateTime.Now,
                Materia = "Biología",
                ValorNota = 90,
                TipoNota = "Trabajo Práctico",
                DescripcionNota = "Informe de laboratorio"
            },

            new Notas
            {
                NotaId = 3,
                Estudiante = "Carlos Gómez",
                Curso = "Historia",
                PeriodoAcademico = "Segundo Periodo",
                FechaCreacion = DateTime.Now,
                Materia = "Historia Mundial",
                ValorNota = 78,
                TipoNota = "Exposición",
                DescripcionNota = "Exposición sobre la Revolución Francesa"
            },

            new Notas
            {
                NotaId = 4,
                Estudiante = "Lucía Fernández",
                Curso = "Literatura",
                PeriodoAcademico = "Segundo Periodo",
                FechaCreacion = DateTime.Now,
                Materia = "Literatura Española",
                ValorNota = 92,
                TipoNota = "Ensayo",
                DescripcionNota = "Análisis del Quijote"
            },

            new Notas
            {
                NotaId = 5,
                Estudiante = "Andrés Martínez",
                Curso = "Física",
                PeriodoAcademico = "Primer Periodo",
                FechaCreacion = DateTime.Now,
                Materia = "Física Cuántica",
                ValorNota = 88,
                TipoNota = "Examen Final",
                DescripcionNota = "Evaluación final del curso"
            }

        );
        }
    }
}
