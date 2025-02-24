using WM_ControlIngreso_Api.Models.Dtos.Usuario;

namespace WM_ControlIngreso_Api.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioLoginResponse> LoginAsync(LoginRequest request);
        // Otros métodos de lógica de negocio
    }
}
