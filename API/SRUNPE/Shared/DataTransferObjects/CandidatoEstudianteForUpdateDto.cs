using Entities.Models.D_Acudiente;
using Entities.Models.D_Estudiante;
using System;
using System.Collections.Generic;

namespace Shared.DataTransferObjects
{
    public record CandidatoEstudianteForUpdateDto
    (
        string Nombre,
        string Apellido,
        DateTime? FechaNacimiento,
        string TipoPersona,
        string TipoDocumento,
        long NumeroDocumento,
        long NumeroContacto,
        string Direccion,
        string Genero,
        string AdjuntarDocumentos,

        string? NombreAcudienteRelacionado // Nombre del acudiente relacionado
    )
    {
        public static CandidatoEstudiante MapToCandidatoEstudiante(CandidatoEstudianteForUpdateDto dto)
        {
            return new CandidatoEstudiante
            {
                Nombre = dto.Nombre,
                Apellido = dto.Apellido,
                FechaNacimiento = dto.FechaNacimiento,
                TipoPersona = dto.TipoPersona,
                TipoDocumento = dto.TipoDocumento,
                NumeroDocumento = dto.NumeroDocumento,
                NumeroContacto = dto.NumeroContacto,
                Direccion = dto.Direccion,
                Genero = dto.Genero,
                AdjuntarDocumentos = dto.AdjuntarDocumentos
            };
        }
    }
}
