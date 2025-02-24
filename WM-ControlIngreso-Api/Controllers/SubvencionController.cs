using Microsoft.AspNetCore.Mvc;
using WM_ControlIngreso_Api.Models.Dtos.Subvencion;
using WM_ControlIngreso_Api.Services.Interfaces;

namespace WM_ControlIngreso_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubvencionController : ControllerBase
    {
        private readonly ISubvencionService _subvencionService;

        public SubvencionController(ISubvencionService subvencionService)
        {
            _subvencionService = subvencionService;
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarSubvenciones([FromQuery] int? mes, [FromQuery] int? anio)
        {
            // Llamas a tu repositorio/servicio con los parámetros
            var resultado = await _subvencionService.ObtenerSubvencionesAsync(mes, anio);
            return Ok(resultado);
        }


        [HttpPost("registrar")]
        public async Task<IActionResult> RegistrarMonto([FromBody] RegistrarMontoRequest request, [FromQuery] int? mes, [FromQuery] int? anio)
        {
            await _subvencionService.RegistrarMontoAsync(request.IdComite, request.IdUsuario, request.Monto, mes, anio );
            return Ok(new { mensaje = "Monto registrado correctamente" });
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarMonto([FromBody] ActualizarMontoRequest request)
        {
            bool actualizado = await _subvencionService.ActualizarMontoAsync(request.IdComite, request.IdUsuario, request.Monto, request.Mes, request.Anio);
            if (actualizado)
            {
                return Ok(new { mensaje = "Monto actualizado correctamente" });
            }
            else
            {
                return NotFound(new { mensaje = "No se encontró el registro de presupuesto para este comité y usuario." });
            }
        }
    }
}
