namespace Shared.DataTransferObjects;

public class DocenteDto
{
    public Guid DocenteId { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DateTime? FechaNacimiento { get; set; }
    public string Genero { get; set; }
    public string Direccion { get; set; }
    public string CorreoElectronico { get; set; }
    public string TituloAcademico  { get; set; }
    public string NumeroTelefono { get; set; }
    public DateTime FechaContratacion { get; set; }
    public string EstadoLaboral { get; set; }
    public string NumeroIdentificacion { get; set; }
    public string ComentariosNotas { get; set; }
    public string NivelExperiencia { get; set; }

    public ICollection<CursoDto> Cursos { get; set; }
    public ICollection<MateriaDto> Materias { get; set; } = new List<MateriaDto>();
    public Guid? HorarioId { get; set; }
    public Guid? AulaId { get; set; }

    public string DiaSemana { get; set; }
    public string NombreNumero { get; set; }

}
