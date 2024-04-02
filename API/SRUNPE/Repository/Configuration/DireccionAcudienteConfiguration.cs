using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Entities.Models.D_Acudiente;

namespace Repository.Configuration;

internal class DireccionAcudienteConfiguration : IEntityTypeConfiguration<DireccionAcudiente>
{
    public void Configure(EntityTypeBuilder<DireccionAcudiente> builder)
    {
        builder.HasData(
            new DireccionAcudiente
            {
                DireccionAcudienteId = Guid.NewGuid(),
                Calle = "Calle 100",
                ColoniaBarrio = "Norte",
                CiudadLocalidad = "Bogotá",
                CodigoPostal = "110111",
                EstadoProvincia = "Bogotá",
                Pais = "Colombia"
            },
            new DireccionAcudiente
            {
                DireccionAcudienteId = Guid.NewGuid(),
                Calle = "Carrera 50",
                ColoniaBarrio = "Sur",
                CiudadLocalidad = "Bogotá",
                CodigoPostal = "110221",
                EstadoProvincia = "Bogotá",
                Pais = "Colombia"
            }
        );
    }
}