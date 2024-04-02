using API.Presentation.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;

namespace API.Presentation.Controllers
{
    [Route("api/notas")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        private readonly IServiceManager _service;

        public NotasController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetNotas()
        {
            var notas = _service.NotaService.GetAllNotas(trackChanges: false);

            return Ok(notas);
        }

        [HttpGet("{id:int}", Name = "NotasById")]
        public IActionResult GetNota(int id)
        {
            var nota = _service.NotaService.GetNota(id, trackChanges: false);
            return Ok(nota);
        }

        [HttpGet("collection/({ids})", Name = "NotasCollection")]
        public IActionResult GetNotaCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<int> ids)
        {
            var notas = _service.NotaService.GetByIds(ids, trackChanges: false);

            return Ok(notas);
        }

        [HttpPost]
        public IActionResult CreateNota([FromBody] NotaForCreationDto nota)
        {
            if (nota is null)
                return BadRequest("NotaForCreationDto object is null");

            var createdNota = _service.NotaService.CreateNota(nota);

            return CreatedAtRoute("NotasById", new { id = createdNota.NotaId }, createdNota);
        }

        [HttpPost("collection")]
        public IActionResult CreateNotaCollection([FromBody] IEnumerable<NotaForCreationDto> notaCollection)
        {
            var result = _service.NotaService.CreateNotaCollection(notaCollection);

            return CreatedAtRoute("NotasCollection", new { ids = result.ids }, result.notas);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteNota(int id)
        {
            _service.NotaService.DeleteNota(id, trackChanges: false);
            return NoContent();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateNota(int id, [FromBody] NotaForUpdateDto nota)
        {
            if (nota is null)
                return BadRequest("NotaForUpdateDto object is null");
            _service.NotaService.UpdateNota(id, nota, trackChanges: true);
            return NoContent();
        }
    }
}
