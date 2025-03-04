using WM_ControlIngreso_Api.Models.Entities;

namespace WM_ControlIngreso_Api.Services.Interfaces
{
    public interface IRacionService
    {
        Task<IEnumerable<Racion>> ObtenerRacionesAsync();
    }
}
