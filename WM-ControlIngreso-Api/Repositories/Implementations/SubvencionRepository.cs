using Microsoft.Data.SqlClient;
using System.Data;
using WM_ControlIngreso_Api.Models.Dtos.Subvencion;
using WM_ControlIngreso_Api.Repositories.Interfaces;
using WM_ControlIngreso_Api.Utils;


namespace WM_ControlIngreso_Api.Repositories.Implementations
{
    public class SubvencionRepository : ISubvencionRepository
    {
        private readonly string _connectionString;

        public SubvencionRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<SubvencionResponse>> ListarSubvencionesAsync(int? mes, int? anio)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand("sp_ListarSubvenciones", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Parám. opcionales
                    command.Parameters.AddWithValue("@Mes", (object)mes ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Anio", (object)anio ?? DBNull.Value);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        var lista = new List<SubvencionResponse>();
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new SubvencionResponse
                            {
                                Region = reader["Region"].ToString(),
                                Provincia = reader["Provincia"].ToString(),
                                Distrito = reader["Distrito"].ToString(),
                                Colegio = reader["Colegio"].ToString(),
                                idComite = int.TryParse(reader["idComite"]?.ToString(), out int result) ? result : -1,
                                Comite = reader["Comite"].ToString(),
                                Monto = (decimal)reader["Monto"],
                                Estado = reader["Estado"].ToString()
                            });
                        }
                        return lista;
                    }
                }
            }
        }

        public async Task RegistrarMontoAsync(int idComite, int idUsuario, decimal monto, int? mes, int? anio)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("sp_RegistrarMontoSubvencion", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idComite", idComite);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@monto", monto);
                    command.Parameters.AddWithValue("@Mes", (object)mes ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Anio", (object)anio ?? DBNull.Value);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<bool> ActualizarMontoAsync(int idComite, int idUsuario, decimal monto, int mes, int anio)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                using (var command = new SqlCommand("sp_ActualizarMontoSubvencion2", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idComite", idComite);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@monto", monto);
                    command.Parameters.AddWithValue("@Mes", mes);
                    command.Parameters.AddWithValue("@Anio", anio);

                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
