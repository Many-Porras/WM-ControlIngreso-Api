namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Distrito
    {
        public int IdDistrito { get; set; }
        public int IdProvincia { get; set; }
        public string NombreDistrito { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relación (opcional)
        public Provincia Provincia { get; set; }
    }
}
