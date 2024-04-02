using Entities.Models.D_Acudiente;

namespace Shared.DataTransferObjects;

public record DireccionAcudienteForUpdateDto(
    string Calle,
    string ColoniaBarrio,
    string CiudadLocalidad,
    string CodigoPostal,
    string EstadoProvincia,
    string Pais,
    Guid AcudienteId
)
{
    public static DireccionAcudiente MapToDireccionAcudiente(DireccionAcudienteForUpdateDto dto)
    {
        return new DireccionAcudiente
        {
            Calle = dto.Calle,
            ColoniaBarrio = dto.ColoniaBarrio,
            CiudadLocalidad = dto.CiudadLocalidad,
            CodigoPostal = dto.CodigoPostal,
            EstadoProvincia = dto.EstadoProvincia,
            Pais = dto.Pais,
            AcudienteId = dto.AcudienteId
        };
    }
}

