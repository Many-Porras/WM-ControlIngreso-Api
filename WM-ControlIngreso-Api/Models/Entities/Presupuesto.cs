namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Presupuesto
    {
        public int IdPresupuesto { get; set; }
        public int IdColegio { get; set; }
        public int IdUsuario { get; set; }
        public decimal MontoPresupuesto { get; set; }
        public DateTime FechaHoraPresupuesto { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relaciones (opcional)
        public Colegio Colegio { get; set; }
        public Usuario Usuario { get; set; }
    }
}
