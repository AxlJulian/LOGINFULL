using Entities.Models.D_Estudiante;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using Entities.Models.D_Acudiente;

namespace Repository.Configuration
{
    public class CandidatoEstudianteConfiguration : IEntityTypeConfiguration<CandidatoEstudiante>
    {
        public void Configure(EntityTypeBuilder<CandidatoEstudiante> builder)
        {
            builder.HasData(
            new CandidatoEstudiante
            {
                CandidatoEstudianteId = Guid.NewGuid(),
                Nombre = "Pedro",
                Apellido = "Gomez",
                FechaNacimiento = new DateTime(2000, 5, 15),
                TipoPersona = "Estudiante",
                TipoDocumento = "CC",
                NumeroDocumento = 123,
                NumeroContacto = 321,
                Direccion = "Calle 123",
                Genero = "Masculino",
                AdjuntarDocumentos = "Documentos adjuntos",
            },

            new CandidatoEstudiante
            {
                CandidatoEstudianteId = Guid.NewGuid(),
                Nombre = "Ana",
                Apellido = "Rodriguez",
                FechaNacimiento = new DateTime(1998, 8, 25),
                TipoPersona = "Estudiante",
                TipoDocumento = "CC",
                NumeroDocumento = 456,
                NumeroContacto = 654,
                Direccion = "Carrera 456",
                Genero = "Femenino",
                AdjuntarDocumentos = "Documentos adjuntos",
            }

        );
        }
    }
}


