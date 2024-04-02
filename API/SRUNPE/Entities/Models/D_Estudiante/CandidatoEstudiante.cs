using Entities.Models.D_Acudiente;
using Entities.Models.LOGIN;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.D_Estudiante;

public partial class CandidatoEstudiante
{
    public Guid CandidatoEstudianteId { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public string TipoPersona { get; set; }
    public string TipoDocumento { get; set; }
    public long NumeroDocumento { get; set; }
    public long NumeroContacto { get; set; }
    public string Direccion { get; set; }
    public string Genero { get; set; }
    public string AdjuntarDocumentos { get; set; }

    // Clave foránea y propiedad de navegación para Acudiente
    public long NumeroIdentificacionAcudiente { get; set; } // Cambio de nombre
    public ICollection<Acudiente> Acudientes { get; set; }
    public ICollection<Usuario> Usuario { get; set; }

    public Guid? Id { get; set; }
    public Usuario usuario { get; set; }


}

