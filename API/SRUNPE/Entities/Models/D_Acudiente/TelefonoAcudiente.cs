namespace Entities.Models.D_Acudiente;

public partial class TelefonoAcudiente
{
    public Guid TelefonoAcudienteId { get; set; }
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public string Indicativo { get; set; }

    // Clave foránea para Acudiente
    public Guid AcudienteId { get; set; }

    // Propiedad de navegación
    public Acudiente Acudiente { get; set; }
}
