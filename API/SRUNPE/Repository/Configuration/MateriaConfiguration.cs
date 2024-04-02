using Entities.Models.D_DepartamentoAcademico;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Repository.Configuration;
public class MateriaConfiguration : IEntityTypeConfiguration<Materias>
{
    public void Configure(EntityTypeBuilder<Materias> builder)
    {
        builder.HasData(
            new Materias
            {
                MateriaId = Guid.NewGuid(),
                Nombre = "Matemáticas Básicas",
                Descripcion = "Fundamentos de aritmética y álgebra",
                DepartamentoAcademico = "Matemáticas",
                Nivel = "Secundaria",
                Creditos = 4,
                Estado = "Activa",
                NotasAdicionales = "Ninguna",
                MetodosEnsenanza = "Clases teóricas y ejercicios prácticos",
                HorasTeoricas = 3,
                HorasPracticas = 2
            },
            new Materias
            {
                MateriaId = Guid.NewGuid(),
                Nombre = "Física General",
                Descripcion = "Introducción a la mecánica, termodinámica y ondas",
                DepartamentoAcademico = "Física",
                Nivel = "Universitaria",
                Creditos = 5,
                Estado = "Activa",
                NotasAdicionales = "Requiere calculadora científica",
                MetodosEnsenanza = "Clases teóricas, laboratorios",
                HorasTeoricas = 4,
                HorasPracticas = 3
            },
            new Materias
            {
                MateriaId = Guid.NewGuid(),
                Nombre = "Literatura Española",
                Descripcion = "Estudio de obras literarias españolas clásicas",
                DepartamentoAcademico = "Humanidades",
                Nivel = "Secundaria",
                Creditos = 3,
                Estado = "Inactiva",
                NotasAdicionales = "Incluye lecturas obligatorias",
                MetodosEnsenanza = "Clases teóricas, discusiones en grupo",
                HorasTeoricas = 3,
                HorasPracticas = 1
            },
            new Materias
            {
                MateriaId = Guid.NewGuid(),
                Nombre = "Biología Avanzada",
                Descripcion = "Análisis profundo de la biología celular",
                DepartamentoAcademico = "Biología",
                Nivel = "Universitaria",
                Creditos = 6,
                Estado = "Activa",
                NotasAdicionales = "Requiere conocimientos previos de biología básica",
                MetodosEnsenanza = "Clases teóricas, laboratorios, proyectos de investigación",
                HorasTeoricas = 4,
                HorasPracticas = 4
            },
            new Materias
            {
                MateriaId = Guid.NewGuid(),
                Nombre = "Historia Mundial",
                Descripcion = "Exploración de eventos históricos globales",
                DepartamentoAcademico = "Historia",
                Nivel = "Secundaria",
                Creditos = 3,
                Estado = "Activa",
                NotasAdicionales = "Se recomienda visitar museos y sitios históricos",
                MetodosEnsenanza = "Clases teóricas, análisis de documentos históricos",
                HorasTeoricas = 3,
                HorasPracticas = 0
            }
        );
    }
}