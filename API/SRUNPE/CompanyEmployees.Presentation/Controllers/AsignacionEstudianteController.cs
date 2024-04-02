using Entities.Models.D_Estudiante;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AsignacionEstudianteController : ControllerBase
{
    private readonly RepositoryContext _context;

    public AsignacionEstudianteController(RepositoryContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult> AsignarCursoAulaHorarioAEstudiante([FromBody] AsignacionEstudianteDto asignacionDto)
    {
        if (asignacionDto == null)
        {
            return BadRequest("La asignación es nula.");
        }

        var estudiante = await _context.CandidatoEstudiantes.FindAsync(asignacionDto.CandidatoEstudianteId);
        var curso = await _context.Cursos.FindAsync(asignacionDto.CursoId);
        var aula = await _context.Aulas.FindAsync(asignacionDto.AulaId);
        var horario = await _context.Horarios.FindAsync(asignacionDto.HorarioId);

        if (estudiante == null || curso == null || aula == null || horario == null)
        {
            return BadRequest("Estudiante, curso, aula o horario no encontrado.");
        }

        // Asumiendo que tienes una entidad AsignacionEstudiante que relaciona estas entidades
        var asignacion = new AsignacionEstudiante
        {
            CandidatoEstudiante = estudiante,
            Cursos = curso,
            Aulas = aula,
            Horarios = horario
        };

        _context.AsignacionesEstudiantes.Add(asignacion);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(ObtenerAsignacionEstudiante), new { id = asignacion.Id }, asignacion);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<int>>> ObtenerTodosLosIdsDeAsignacionesEstudiantes()
    {
        var asignacionesIds = await _context.AsignacionesEstudiantes
            .Select(a => a.Id)
            .ToListAsync();

        if (!asignacionesIds.Any())
        {
            return NotFound("No se encontraron asignaciones.");
        }

        return Ok(asignacionesIds);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<AsignacionEstudiante>> ObtenerAsignacionEstudiante(int id)
    {
        var asignacion = await _context.AsignacionesEstudiantes
            .Include(a => a.CandidatoEstudiante)
            .Include(a => a.Cursos)
            .Include(a => a.Aulas)
            .Include(a => a.Horarios)
            .FirstOrDefaultAsync(a => a.Id == id);

        if (asignacion == null)
        {
            return NotFound();
        }

        return asignacion;
    }

    // Agrega más métodos según sea necesario...
}
