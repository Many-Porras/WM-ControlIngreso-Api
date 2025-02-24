namespace WM_ControlIngreso_Api.Models.Dtos.Usuario
{
    public class LoginRequest
    {
        public string NumeroDocumentoUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public int? IdPerfil { get; set; }
        public int? IdRol { get; set; }
    }
}
