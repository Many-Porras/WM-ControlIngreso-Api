using WM_ControlIngreso_Api.Models.Dtos.Subvencion;

namespace WM_ControlIngreso_Api.Services.Interfaces
{
    public interface ISubvencionService
    {
        Task<List<SubvencionResponse>> ObtenerSubvencionesAsync(int? mes, int? anio);
        Task RegistrarMontoAsync(int idComite, int idUsuario, decimal monto, int? mes, int? anio);
        Task<bool> ActualizarMontoAsync(int idComite, int idUsuario, decimal monto, int mes, int anio);
    }
}
