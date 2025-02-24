namespace WM_ControlIngreso_Api.Models.Entities
{
    public class Colegio
    {
        public int IdColegio { get; set; }
        public int IdDistrito { get; set; }
        public string CodigoModularColegio { get; set; }
        public string NombreColegio { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relación (opcional)
        public Distrito Distrito { get; set; }
    }
}
