using Microsoft.Data.SqlClient;
using System.Data;
using WM_ControlIngreso_Api.Models.Entities;
using WM_ControlIngreso_Api.Repositories.Interfaces;

namespace WM_ControlIngreso_Api.Repositories.Implementations
{
    public class RacionRepository : IRacionRepository
    {
        private readonly string _connectionString;

        public RacionRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        public async Task<IEnumerable<Racion>> ListarRacionesAsync()
        {
            var raciones = new List<Racion>();

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand("sp_ListarRacionesOptimizado", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            raciones.Add(new Racion
                            {
                                IdRaciones = reader.GetInt32(0),
                                NombreRacion = reader.GetString(1),
                                FechaCreacion = reader.GetDateTime(2),
                                FechaUpdate = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3)
                            });
                        }
                    }
                }
            }

            return raciones;
        }
    }

}
