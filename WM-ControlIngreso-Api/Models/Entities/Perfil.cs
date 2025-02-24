namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Navegación
        public ICollection<Rol> Roles { get; set; }
    }
}
