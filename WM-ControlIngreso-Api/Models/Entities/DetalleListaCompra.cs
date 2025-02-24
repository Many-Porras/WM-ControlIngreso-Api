namespace WM_ControlIngreso_Api.Models.Entities
{
    public class DetalleListaCompra
    {
        public int IdDetalleListaCompra { get; set; }
        public int IdListaCompra { get; set; }
        public int IdDetalleInsumo { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relaciones (opcional)
        public ListaCompra ListaCompra { get; set; }
        public DetalleInsumo DetalleInsumo { get; set; }
    }
}
