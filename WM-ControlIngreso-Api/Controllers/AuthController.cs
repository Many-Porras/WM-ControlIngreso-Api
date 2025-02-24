using Microsoft.AspNetCore.Mvc;
using WM_ControlIngreso_Api.Models.Dtos.Usuario;
using WM_ControlIngreso_Api.Services.Interfaces;

namespace WM_ControlIngreso_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public AuthController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            if (string.IsNullOrEmpty(request.NumeroDocumentoUsuario) || string.IsNullOrEmpty(request.PasswordUsuario))
            {
                return BadRequest("Los campos 'NumeroDocumentoUsuario' y 'PasswordUsuario' son obligatorios.");
            }

            var usuario = await _usuarioService.LoginAsync(request);

            if (usuario == null)
            {
                return Unauthorized("Credenciales inválidas o no coincide con el rol/perfil.");
            }

            // Si necesitas JWT, aquí podrías generarlo y retornarlo junto con la info del usuario
            return Ok(usuario);
        }

    }
}
