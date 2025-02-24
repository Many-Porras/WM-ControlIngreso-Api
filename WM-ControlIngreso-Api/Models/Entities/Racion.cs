namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Racion
    {
        public int IdRaciones { get; set; }
        public string NombreRacion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }
    }
}
