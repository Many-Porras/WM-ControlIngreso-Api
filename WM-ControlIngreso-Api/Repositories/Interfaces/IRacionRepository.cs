using WM_ControlIngreso_Api.Models.Entities;

namespace WM_ControlIngreso_Api.Repositories.Interfaces
{
    public interface IRacionRepository
    {
        Task<IEnumerable<Racion>> ListarRacionesAsync();
    }
}
