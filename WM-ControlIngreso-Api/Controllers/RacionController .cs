using Microsoft.AspNetCore.Mvc;
using WM_ControlIngreso_Api.Services.Interfaces;

namespace WM_ControlIngreso_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RacionController : ControllerBase
    {
        private readonly IRacionService _racionService;

        public RacionController(IRacionService racionService)
        {
            _racionService = racionService;
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarRaciones()
        {
            var raciones = await _racionService.ObtenerRacionesAsync();
            return Ok(raciones);
        }
    }
}
