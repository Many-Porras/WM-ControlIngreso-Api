namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Comite
    {
        public int IdComite { get; set; }
        public int IdColegio { get; set; }
        public string NombreComite { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relación (opcional)
        public Colegio Colegio { get; set; }
    }
}
