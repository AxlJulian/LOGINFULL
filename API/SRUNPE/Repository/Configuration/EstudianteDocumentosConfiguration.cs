using Entities.Models.D_Estudiante;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class EstudianteDocumentosConfiguration : IEntityTypeConfiguration<EstudianteDocumentos>
{
    public void Configure(EntityTypeBuilder<EstudianteDocumentos> builder)
    {
        builder.HasData
        (
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("6a30c846-4b9d-4cf5-bb17-051a3e9d1b72"),
                NombreDocumento = "Certificado de Nacimiento",
                TipoDocumento = "Identificación",
                NumeroDocumento = 61464465,
                Estado = true,
                Observaciones = "Ninguna",
                FechaActualizacion = null,
                Ubicacion = "ruta/al/documento1",
                Tamaño = 1024 // Tamaño en bytes
            },
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("2d54a999-187f-4a8c-99db-d17841e7938c"),
                NombreDocumento = "Diploma",
                TipoDocumento = "Educativo",
                NumeroDocumento = 987654,
                Estado = true,
                Observaciones = "Logros académicos",
                FechaActualizacion = DateTime.Now,
                Ubicacion = "ruta/al/documento2",
                Tamaño = 2048 // Tamaño en bytes
            },
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("3e68515e-3a47-4a62-a8c7-9f12242d020e"),
                NombreDocumento = "Certificado de Graduación",
                TipoDocumento = "Educativo",
                NumeroDocumento = 123456,
                Estado = false,
                Observaciones = "Graduación universitaria",
                FechaActualizacion = DateTime.Now,
                Ubicacion = "ruta/al/documento3",
                Tamaño = 1536 // Tamaño en bytes
            },
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("4a303cce-8c0e-4ae7-89c1-067d0b7741b6"),
                NombreDocumento = "Certificado de Matrícula",
                TipoDocumento = "Educativo",
                NumeroDocumento = 789012,
                Estado = true,
                Observaciones = "Matrícula escolar",
                FechaActualizacion = DateTime.Now,
                Ubicacion = "ruta/al/documento4",
                Tamaño = 8192 // Tamaño en bytes
            },
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("5f78d0e1-579e-4dfc-82a1-92010b4191d3"),
                NombreDocumento = "Cédula de Identidad",
                TipoDocumento = "Identificación",
                NumeroDocumento = 555555,
                Estado = true,
                Observaciones = "Documento oficial",
                FechaActualizacion = DateTime.Now,
                Ubicacion = "ruta/al/documento5",
                Tamaño = 4096 // Tamaño en bytes
            },
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("f38f6b1a-86e9-4d9d-8a7a-62f17e6f1ba2"),
                NombreDocumento = "Carné de Estudiante",
                TipoDocumento = "Identificación",
                NumeroDocumento = 7890123,
                Estado = true,
                Observaciones = "Carné escolar",
                FechaActualizacion = DateTime.Now,
                Ubicacion = "ruta/al/documento6",
                Tamaño = 3072 // Tamaño en bytes
            },
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("7e15d9a4-98cb-4d14-9a35-862f8c202725"),
                NombreDocumento = "Boleta de Calificaciones",
                TipoDocumento = "Educativo",
                NumeroDocumento = 9876543,
                Estado = true,
                Observaciones = "Registro académico",
                FechaActualizacion = DateTime.Now,
                Ubicacion = "ruta/al/documento7",
                Tamaño = 5120 // Tamaño en bytes
            },
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("8f4a67c2-fd5e-4316-8c50-7249f159d0f1"),
                NombreDocumento = "Pasaporte",
                TipoDocumento = "Identificación",
                NumeroDocumento = 1234567,
                Estado = true,
                Observaciones = "Documento de viaje",
                FechaActualizacion = DateTime.Now,
                Ubicacion = "ruta/al/documento8",
                Tamaño = 4096 // Tamaño en bytes
            },
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("9b9d6d8f-72f0-4f0a-8e18-1e75b0182e3f"),
                NombreDocumento = "Certificado Médico",
                TipoDocumento = "Salud",
                NumeroDocumento = 543210,
                Estado = true,
                Observaciones = "Informe médico",
                FechaActualizacion = DateTime.Now,
                Ubicacion = "ruta/al/documento9",
                Tamaño = 2048 // Tamaño en bytes
            },
            new EstudianteDocumentos
            {
                EstudianteDocumentosId = new Guid("10a5e754-1570-4be0-8650-2c53d7cfb4d3"),
                NombreDocumento = "Fotografía del Estudiante",
                TipoDocumento = "Identificación",
                NumeroDocumento = 1111111,
                Estado = true,
                Observaciones = "Foto de perfil",
                FechaActualizacion = DateTime.Now,
                Ubicacion = "ruta/al/documento10",
                Tamaño = 1024 // Tamaño en bytes
            }
        );
    }
}
