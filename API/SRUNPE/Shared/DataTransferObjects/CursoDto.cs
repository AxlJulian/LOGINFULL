﻿
namespace Shared.DataTransferObjects;

public record CursoDto
{
    public Guid CursoId { get; set; }
    public string CodigoCurso { get; set; }
    public string Descripcion { get; set; }
    public string DepartamentoAcademico { get; set; }
    public string Nivel { get; set; }
    public string MetodosEnsenanza { get; set; }
    public int Año { get; set; }
    public int CupoMaximo { get; set; }
    public int CupoActual { get; set; }
    public string? Estado { get; set; }
    public string? Modalidad { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFinalizacion { get; set; }
}