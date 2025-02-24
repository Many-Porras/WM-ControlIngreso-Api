using WM_ControlIngreso_Api.Models.Dtos.Usuario;
using WM_ControlIngreso_Api.Repositories.Interfaces;
using WM_ControlIngreso_Api.Services.Interfaces;

namespace WM_ControlIngreso_Api.Services.Implementations
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioLoginResponse> LoginAsync(LoginRequest request)
        {
            // Aquí podrías hacer validaciones extras, encriptar contraseñas, etc.
            var usuario = await _usuarioRepository.LoginAsync(request);
            return usuario;
        }
    }
}
