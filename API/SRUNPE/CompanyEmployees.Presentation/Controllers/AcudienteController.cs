using API.Presentation.ModelBinders;
using Entities.Models.D_Acudiente;
using Entities.Models.D_Estudiante;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace API.Presentation.Controllers;

[Route("api/acudiente")]
[ApiController]
public class AcudientesController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly RepositoryContext _context;

    public AcudientesController(IServiceManager service, RepositoryContext context)
    {
        _service = service;
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAcudientes()
    {
        var acudientes = _context.Acudientes
                                 .Include(a => a.DireccionAcudiente) // Incluye la dirección
                                 .Include(a => a.TelefonosAcudiente) // Incluye los teléfonos
                                 .ToList();

        var acudientesDto = acudientes.Select(a => new
        {
            a.AcudienteId,
            a.Nombres,
            a.Apellidos,
            a.NumeroIdentificacion,
            a.Edad,
            a.CorreoElectronico,
            a.RelacionConEstudiante,
            a.EstadoCivil,
            a.Ocupacion,
            a.FechaRegistro,
            Direccion = a.DireccionAcudiente != null ? new
            {
                a.DireccionAcudiente.DireccionAcudienteId,
                a.DireccionAcudiente.Calle,
                a.DireccionAcudiente.ColoniaBarrio,
                a.DireccionAcudiente.CiudadLocalidad,
                a.DireccionAcudiente.CodigoPostal,
                a.DireccionAcudiente.EstadoProvincia,
                a.DireccionAcudiente.Pais
            } : null,
            Telefonos = a.TelefonosAcudiente.Select(t => new
            {
                t.TelefonoAcudienteId,
                t.Numero,
                t.Tipo,
                t.Indicativo
            }).ToList(),
            EstudiantesRelacionados = _context.CandidatoEstudiantes
                .Where(c => c.NumeroIdentificacionAcudiente == a.NumeroIdentificacion)
                .Select(c => $"{c.Nombre} {c.Apellido}")
                .ToList()
        }).ToList();

        return Ok(acudientesDto);
    }


    [HttpGet("{id:guid}", Name = "AcudienteById")]
    public IActionResult GetAcudiente(Guid id)
    {
        var acudiente = _service.AcudienteService.GetAcudiente(id, trackChanges: false);
        return Ok(acudiente);
    }

    [HttpGet("collection/({ids})", Name = "AcudienteCollection")]
    public IActionResult GetAcudienteCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
    {
        var acudientes = _service.AcudienteService.GetByIds(ids, trackChanges: false);
        return Ok(acudientes);
    }

    [HttpPost]
    public async Task<ActionResult<Acudiente>> CreateAcudiente([FromBody] AcudienteForCreationDto acudiente)
    {
        if (acudiente is null)
            return BadRequest("AcudienteForCreationDto object is null");

        var createdAcudiente = _service.AcudienteService.CreateAcudiente(acudiente);
        return CreatedAtRoute("AcudienteById", new { id = createdAcudiente.AcudienteId }, createdAcudiente);
    }

    [HttpPost("byNumber")]
    public async Task<ActionResult<Acudiente>> PostAcudienteByNumber(Acudiente acudiente)
    {
        var candidatoEstudiante = await _context.CandidatoEstudiantes.FirstOrDefaultAsync(c => c.NumeroDocumento == acudiente.NumeroIdentificacionEstudiante);

        if (candidatoEstudiante != null)
        {
            candidatoEstudiante.Acudientes.Add(acudiente);
            _context.Acudientes.Add(acudiente); // Corrección aquí
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetAcudiente", new { id = acudiente.AcudienteId }, acudiente);
        }
        else
        {
            return BadRequest("No se encontró el candidato estudiante con el número de identificación proporcionado.");
        }
    }



    [HttpDelete("{id:guid}")]
    public IActionResult DeleteAcudiente(Guid id)
    {
        _service.AcudienteService.DeleteAcudiente(id, trackChanges: false);
        return NoContent();
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateAcudiente(Guid id, [FromBody] AcudienteForUpdateDto acudiente)
    {
        if (acudiente is null)
            return BadRequest("AcudienteForUpdateDto object is null");

        _service.AcudienteService.UpdateAcudiente(id, acudiente, trackChanges: true);
        return NoContent();
    }
}
