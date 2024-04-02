using Entities.Models.D_Docente;
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
public class AsignacionDocenteController : ControllerBase
{
    private readonly RepositoryContext _context;

    public AsignacionDocenteController(RepositoryContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<AsignacionDocente>> AsignarMateriaCursoADocente([FromBody] AsignacionDocenteDto asignacionDto)
    {
        if (asignacionDto == null)
        {
            return BadRequest("La asignación es nula.");
        }

        var docente = await _context.Docentes.FindAsync(asignacionDto.DocenteId);
        var materia = await _context.Materias.FindAsync(asignacionDto.MateriaId);
        var curso = await _context.Cursos.FindAsync(asignacionDto.CursoId);

        if (docente == null || materia == null || curso == null)
        {
            return BadRequest("Docente, materia o curso no encontrado.");
        }

        var asignacion = new AsignacionDocente
        {
            Docente = docente,
            Materia = materia,
            Curso = curso
        };

        _context.AsignacionesDocentes.Add(asignacion);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(ObtenerAsignacion), new { id = asignacion.Id }, asignacion);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<int>>> ObtenerTodosLosIdsDeAsignaciones()
    {
        var asignacionesIds = await _context.AsignacionesDocentes
            .Select(a => a.Id)
            .ToListAsync();

        if (!asignacionesIds.Any())
        {
            return NotFound("No se encontraron asignaciones.");
        }

        return Ok(asignacionesIds);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<AsignacionDocente>> ObtenerAsignacion(int id)
    {
        var asignacion = await _context.AsignacionesDocentes
            .Include(a => a.Docente)
            .Include(a => a.Materia)
            .Include(a => a.Curso)
            .FirstOrDefaultAsync(a => a.Id == id);

        if (asignacion == null)
        {
            return NotFound();
        }

        return asignacion;
    }

    // Puedes agregar más métodos para actualizar o eliminar asignaciones si lo necesitas.
}
