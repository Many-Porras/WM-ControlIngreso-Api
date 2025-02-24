namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public int IdComite { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string TipoDocumentoUsuario { get; set; }
        public string NumeroDocumentoUsuario { get; set; }
        public string CelularUsuario { get; set; }
        public string PasswordUsuario { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relaciones (opcional, según la implementación)
        public Rol Rol { get; set; }
    }
}
