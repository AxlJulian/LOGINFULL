using API.Presentation.ModelBinders;
using Entities.Models.D_Estudiante;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Presentation.Controllers;

[Route("api/candidatoEstudiante")]
[ApiController]
public class CandidatoEstudiantesController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly RepositoryContext _context;

    public CandidatoEstudiantesController(IServiceManager service, RepositoryContext context)
    {
        _service = service;
        _context = context;
    }

    [HttpGet]
    public IActionResult GetCandidatoEstudiantes()
    {
        var candidatoEstudiante = _context.CandidatoEstudiantes
            .Select(ce => new
            {
                ce.CandidatoEstudianteId,
                ce.Nombre,
                ce.Apellido,
                ce.FechaNacimiento,
                ce.TipoPersona,
                ce.TipoDocumento,
                ce.NumeroDocumento,
                ce.NumeroContacto,
                ce.Direccion,
                ce.Genero,
                ce.AdjuntarDocumentos,
                AcudienteRelacionado = _context.Acudientes
                .Where(c => c.NumeroIdentificacionEstudiante == ce.NumeroDocumento)
                .Select(c => $"{c.Nombres} {c.Apellidos}")
                .ToList()
            }).ToList();

        return Ok(candidatoEstudiante);
    }


    [HttpGet("{id:guid}", Name = "CandidatoEstudianteById")]
    public IActionResult GetCandidatoEstudiante(Guid id)
    {
        var candidatoEstudiante = _service.CandidatoEstudianteService.GetCandidatoEstudiante(id, trackChanges: false);
        return Ok(candidatoEstudiante);
    }

    [HttpPost]
    public IActionResult CreateCandidatoEstudiante([FromBody] CandidatoEstudianteForCreationDto candidatoEstudiante)
    {
        if (candidatoEstudiante is null)
            return BadRequest("CandidatoEstudianteForCreationDto object is null");

        var createdCandidatoEstudiante = _service.CandidatoEstudianteService.CreateCandidatoEstudiante(candidatoEstudiante);

        return CreatedAtRoute("CandidatoEstudianteById", new { id = createdCandidatoEstudiante.CandidatoEstudianteId }, createdCandidatoEstudiante);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteCandidatoEstudiante(Guid id)
    {
        _service.CandidatoEstudianteService.DeleteCandidatoEstudiante(id, trackChanges: false);
        return NoContent();
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateCandidatoEstudiante(Guid id, [FromBody] CandidatoEstudianteForUpdateDto candidatoEstudiante)
    {
        if (candidatoEstudiante is null)
            return BadRequest("CandidatoEstudianteUpdateDto object is null");
        _service.CandidatoEstudianteService.UpdateCandidatoEstudiante(id, candidatoEstudiante, trackChanges: true);
        return NoContent();
    }

    

}
