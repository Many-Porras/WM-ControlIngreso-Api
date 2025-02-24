namespace WM_ControlIngreso_Api.Models.Entities
{
    public class RegistroOrdenCompra
    {
        public int IdRegistroOrdenCompra { get; set; }
        public int IdDetalleListaCompra { get; set; }
        public string TipoSustento { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relación (opcional)
        public DetalleListaCompra DetalleListaCompra { get; set; }
    }
}
