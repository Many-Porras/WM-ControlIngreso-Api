namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Insumo
    {
        public int IdInsumo { get; set; }
        public string NombreInsumo { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }
    }
}
