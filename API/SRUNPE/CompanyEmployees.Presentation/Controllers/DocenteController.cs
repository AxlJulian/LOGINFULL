using API.Presentation.ModelBinders;
using Entities.Exceptions;
using Entities.Models.D_DepartamentoAcademico;
using Entities.Models.D_Docente;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Collections.Generic;

namespace API.Presentation.Controllers;

[Route("api/docente")]
[ApiController]
public class DocentesController : ControllerBase
{
    private readonly IServiceManager _service;
    private readonly RepositoryContext _context;

    public DocentesController(IServiceManager service, RepositoryContext context)
    {
        _service = service;
        _context = context;
    }

    [HttpGet]
    public IActionResult GetDocentes()
    {
        var docentes = _service.DocenteService.GetAllDocentes(trackChanges: false);

        return Ok(docentes);
    }

    [HttpGet("{id:guid}", Name = "DocenteById")]
    public IActionResult GetDocente(Guid id)
    {
        var docente = _service.DocenteService.GetDocente(id, trackChanges: false);
        return Ok(docente);
    }

    [HttpGet("collection/({ids})", Name = "DocenteCollection")]
    public IActionResult GetDocenteCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
    {
        var docentes = _service.DocenteService.GetByIds(ids, trackChanges: false);

        return Ok(docentes);
    }




    [HttpPost]
    public IActionResult CreateDocente([FromBody] DocenteForCreationDto docente)
    {
        if (docente is null)
            return BadRequest("DocenteForCreationDto object is null");

        var createdDocente = _service.DocenteService.CreateDocente(docente);

        return CreatedAtRoute("DocenteById", new { id = createdDocente.DocenteId }, createdDocente);
    }

    [HttpPost("collection")]
    public IActionResult CreateDocenteCollection([FromBody] IEnumerable<DocenteForCreationDto> docenteCollection)
    {
        var result = _service.DocenteService.CreateDocenteCollection(docenteCollection);

        return CreatedAtRoute("DocenteCollection", new { ids = result.ids }, result.docente);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteDocente(Guid id)
    {
        _service.DocenteService.DeleteDocente(id, trackChanges: false);
        return NoContent();
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateDocente(Guid id, [FromBody] DocenteForUpdateDto docente)
    {
        if (docente is null)
            return BadRequest("DocenteForUpdateDto object is null");

        _service.DocenteService.UpdateDocente(id, docente, trackChanges: true);
        return NoContent();
    }

    [HttpPut("{docenteId:guid}/horario/{horarioId:guid}")]
    public IActionResult AssignHorarioToDocente(Guid docenteId, Guid horarioId)
    {
        _service.DocenteService.AssignHorarioToDocente(docenteId, horarioId);
        return NoContent();
    }

    [HttpPut("{docenteId:guid}/aula/{aulaId:guid}")]
    public IActionResult AssignAulaToDocente(Guid docenteId, Guid aulaId)
    {
        _service.DocenteService.AssignAulaToDocente(docenteId, aulaId);
        return NoContent();
    }

    [HttpPut("{docenteId:guid}/cursos")]
    public IActionResult AssignCursosToDocente(Guid docenteId, [FromBody] IEnumerable<Guid> cursoIds)
    {
        _service.DocenteService.AssignCursosToDocente(docenteId, cursoIds);
        return NoContent();
    }

    //[HttpPut("{docenteId:guid}/materias")]
    //public IActionResult AssignMateriasToDocente(Guid docenteId, [FromBody] AssignMateriasDto dto)
    //{
    //    var result = _service.DocenteService.AssignMateriasToDocente(docenteId, dto);
    //    if (!result)
    //    {
    //        return BadRequest("No se pudo asignar las materias al docente.");
    //    }
    //    return NoContent();
    //}


}



