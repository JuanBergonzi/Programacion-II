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
        public IActionResult GetCelular()
        {
            Ok(_service.GetCelulares());
            return Ok(_service.GetCelulares());
        }


        [HttpGet("{id}")]
        public IActionResult GetCelularId(int id)
        {
            var celular = _service.GetCelularesId(id);
            if (celular == null) return NotFound();
            return Ok(celular);
        }

        [HttpPost]
        public IActionResult PostCelular( Celular celular)
        {
            _service.AgregarCelulares(celular);
            return CreatedAtAction(nameof(GetCelular), new { id = celular.Id }, celular);
        }

        [HttpPut("{id}")]
        public IActionResult PutCelular(int id, Celular celular)
        {
            if (id != celular.Id) return BadRequest();
            _service.ActualizarCelulares(celular);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCelular(int id)
        {
            _service.DeleteCelulares(id);
            return NoContent();
        }
    }
}