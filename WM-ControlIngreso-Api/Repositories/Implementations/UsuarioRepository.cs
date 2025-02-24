using Microsoft.Data.SqlClient;
using System.Data;
using WM_ControlIngreso_Api.Models.Dtos.Usuario;
using WM_ControlIngreso_Api.Repositories.Interfaces;

namespace WM_ControlIngreso_Api.Repositories.Implementations
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly string _connectionString;

        public UsuarioRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<UsuarioLoginResponse> LoginAsync(LoginRequest request)
        {
            UsuarioLoginResponse usuario = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand("sp_LoginUsuarioByRolPerfil", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numeroDocumentoUsuario", request.NumeroDocumentoUsuario);
                cmd.Parameters.AddWithValue("@passwordUsuario", request.PasswordUsuario);
                cmd.Parameters.AddWithValue("@idPerfil", (object)request.IdPerfil ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@idRol", (object)request.IdRol ?? DBNull.Value);

                await conn.OpenAsync();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        usuario = new UsuarioLoginResponse
                        {
                            IdUsuario = Convert.ToInt32(reader["idUsuario"]),
                            NombreUsuario = reader["nombreUsuario"].ToString(),
                            ApellidoUsuario = reader["apellidoUsuario"].ToString(),
                            NumeroDocumentoUsuario = reader["numeroDocumentoUsuario"].ToString(),
                            IdRol = Convert.ToInt32(reader["idRol"]),
                            NombreRol = reader["nombreRol"].ToString(),
                            IdPerfil = Convert.ToInt32(reader["idPerfil"]),
                            NombrePerfil = reader["nombrePerfil"].ToString(),
                            FechaCreacion = Convert.ToDateTime(reader["fechaCreacion"])
                        };
                    }
                }
            }

            return usuario;
        }
    }
}
