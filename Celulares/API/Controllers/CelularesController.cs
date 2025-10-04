using Microsoft.AspNetCore.Mvc;
using Celulares.Celulares;
using CLogica.Implementation.Contracts;
namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CelularesController : ControllerBase
    {
        private readonly ICelularService _service;

        public CelularesController(ICelularService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var celular = _service.GetById(id);
            if (celular == null) return NotFound();
            return Ok(celular);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Celular celular)
        {
            _service.Add(celular);
            return CreatedAtAction(nameof(Get), new { id = celular.Id }, celular);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Celular celular)
        {
            if (id != celular.Id) return BadRequest();
            _service.Update(celular);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}