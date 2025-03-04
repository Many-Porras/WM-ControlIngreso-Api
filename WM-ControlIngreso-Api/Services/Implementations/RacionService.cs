using WM_ControlIngreso_Api.Models.Entities;
using WM_ControlIngreso_Api.Repositories.Interfaces;
using WM_ControlIngreso_Api.Services.Interfaces;

namespace WM_ControlIngreso_Api.Services.Implementations
{
    public class RacionService : IRacionService
    {
        private readonly IRacionRepository _racionRepository;

        public RacionService(IRacionRepository racionRepository)
        {
            _racionRepository = racionRepository;
        }

        public async Task<IEnumerable<Racion>> ObtenerRacionesAsync()
        {
            return await _racionRepository.ListarRacionesAsync();
        }
    }
}
