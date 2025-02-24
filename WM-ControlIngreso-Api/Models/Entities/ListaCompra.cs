namespace WM_ControlIngreso_Api.Models.Entities
{
    public class ListaCompra
    {
        public int IdListaCompra { get; set; }
        public int IdUsuario { get; set; }
        public string NumeroCompras { get; set; }
        public int CantidadUsuarios { get; set; }
        public string NivelEducativo { get; set; }
        public string Firma { get; set; }
        public int? IdFirma { get; set; }
        public DateTime FechaDia { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relación (opcional)
        public Usuario Usuario { get; set; }
    }
}
