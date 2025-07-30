using Microsoft.AspNetCore.Mvc;

namespace arquetipo_net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EjemploController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var objetoEjemplo = new
            {
                id = 1,
                nombre = "Objeto de ejemplo",
                descripcion = "Este es un objeto de ejemplo retornado por la API",
                fecha = DateTime.UtcNow
            };
            return Ok(objetoEjemplo);
        }
    }
}
