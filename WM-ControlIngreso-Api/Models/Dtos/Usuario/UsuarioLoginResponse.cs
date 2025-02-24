namespace WM_ControlIngreso_Api.Models.Dtos.Usuario
{
    public class UsuarioLoginResponse
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string NumeroDocumentoUsuario { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
