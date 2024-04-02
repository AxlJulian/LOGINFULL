using Entities.Models.D_Acudiente;

namespace Shared.DataTransferObjects;

public record TelefonoAcudienteForUpdateDto(
    int Numero,
    string Tipo,
    string Indicativo,
    Guid AcudienteId
)
{
    public static TelefonoAcudiente MapToTelefonoAcudiente(TelefonoAcudienteForUpdateDto dto)
    {
        return new TelefonoAcudiente
        {
            Numero = dto.Numero,
            Tipo = dto.Tipo,
            Indicativo = dto.Indicativo,
            AcudienteId = dto.AcudienteId
        };
    }
}
