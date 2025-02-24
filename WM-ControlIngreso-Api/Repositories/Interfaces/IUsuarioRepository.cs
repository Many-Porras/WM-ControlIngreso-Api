using WM_ControlIngreso_Api.Models.Dtos.Usuario;

namespace WM_ControlIngreso_Api.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<UsuarioLoginResponse> LoginAsync(LoginRequest request);
    }
}
