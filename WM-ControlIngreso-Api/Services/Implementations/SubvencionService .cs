using WM_ControlIngreso_Api.Models.Dtos.Subvencion;
using WM_ControlIngreso_Api.Repositories.Interfaces;
using WM_ControlIngreso_Api.Services.Interfaces;

namespace WM_ControlIngreso_Api.Services.Implementations
{
    public class SubvencionService : ISubvencionService
    {
        private readonly ISubvencionRepository _subvencionRepository;

        public SubvencionService(ISubvencionRepository subvencionRepository)
        {
            _subvencionRepository = subvencionRepository;
        }

        public async Task<List<SubvencionResponse>> ObtenerSubvencionesAsync(int? mes, int? anio)
        {
            return await _subvencionRepository.ListarSubvencionesAsync(mes, anio);
        }


        public async Task RegistrarMontoAsync(int idComite, int idUsuario, decimal monto, int? mes, int? anio)
        {
            await _subvencionRepository.RegistrarMontoAsync(idComite, idUsuario, monto, mes, anio);
        }

        public async Task<bool> ActualizarMontoAsync(int idComite, int idUsuario, decimal monto, int mes, int anio)
        {
            return await _subvencionRepository.ActualizarMontoAsync(idComite, idUsuario, monto, mes, anio);
        }

    }
}
