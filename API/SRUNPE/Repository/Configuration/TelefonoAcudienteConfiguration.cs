using Entities.Models;
using Entities.Models.D_Acudiente;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;
public class TelefonoAcudienteConfiguration : IEntityTypeConfiguration<TelefonoAcudiente>
{
    public void Configure(EntityTypeBuilder<TelefonoAcudiente> builder)
    {
        builder.HasData
        (
            new TelefonoAcudiente
            {
                TelefonoAcudienteId = Guid.NewGuid(),
                Numero = 555-123-4567,
                Tipo = "Móvil",
                Indicativo = "+1",
            },
            new TelefonoAcudiente
            {
                TelefonoAcudienteId = Guid.NewGuid(),
                Numero = 555-987-6543,
                Tipo = "Móvil",
                Indicativo = "+1",
            }
        );
    }
}