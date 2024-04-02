using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public record DireccionAcudienteDto
    {
        public Guid DireccionAcudienteId { get; set; }
        public string Calle { get; set; }
        public string ColoniaBarrio { get; set; }
        public string CiudadLocalidad { get; set; }
        public string CodigoPostal { get; set; }
        public string EstadoProvincia { get; set; }
        public string Pais { get; set; }

        // Clave foránea para Acudiente
        public Guid AcudienteId { get; set; }
    }
}
