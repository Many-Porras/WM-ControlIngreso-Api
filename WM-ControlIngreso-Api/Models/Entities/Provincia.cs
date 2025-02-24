namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public int IdRegion { get; set; }
        public string NombreProvincia { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relación (opcional)
        public Region Region { get; set; }
    }
}
