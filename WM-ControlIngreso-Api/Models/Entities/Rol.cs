namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Rol
    {
        public int IdRol { get; set; }
        public int IdPerfil { get; set; }
        public string NombreRol { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relación (opcional, según la implementación)
        public Perfil Perfil { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
    }
}
