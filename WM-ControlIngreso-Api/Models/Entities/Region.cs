namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Region
    {
        public int IdRegion { get; set; }
        public string NombreRegion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }
    }
}
