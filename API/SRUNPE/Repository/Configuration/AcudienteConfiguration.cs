using Entities.Models.D_Acudiente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Repository.Configuration
{
    internal class AcudienteConfiguration : IEntityTypeConfiguration<Acudiente>
    {
        public void Configure(EntityTypeBuilder<Acudiente> builder)

        {
            builder.HasData(

            new Acudiente
            {
                AcudienteId = Guid.NewGuid(),
                Nombres = "Juan",
                Apellidos = "Perez",
                NumeroIdentificacion = 123456789,
                Edad = 45,
                CorreoElectronico = "juan.perez@example.com",
                RelacionConEstudiante = "Padre",
                EstadoCivil = "Casado",
                Ocupacion = "Ingeniero",
                FechaRegistro = DateTime.Now,
            },

            new Acudiente
            {
                AcudienteId = Guid.NewGuid(),
                Nombres = "Maria",
                Apellidos = "Lopez",
                NumeroIdentificacion = 987654321,
                Edad = 40,
                CorreoElectronico = "maria.lopez@example.com",
                RelacionConEstudiante = "Madre",
                EstadoCivil = "Casada",
                Ocupacion = "Abogada",
                FechaRegistro = DateTime.Now,
            }

        );
        }
    }
}




