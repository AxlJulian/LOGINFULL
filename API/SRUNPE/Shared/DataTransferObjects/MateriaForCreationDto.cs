namespace Shared.DataTransferObjects;

public record MateriaForCreationDto(string Nombre,
    string Descripcion,
    string DepartamentoAcademico,
    string Nivel,
    int Creditos,
    string Estado,
    string NotasAdicionales,
    string MetodosEnsenanza,
    int HorasTeoricas,
    int HorasPracticas,

    string? DocenteNombre
    );