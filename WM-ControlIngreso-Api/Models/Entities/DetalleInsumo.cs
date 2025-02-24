using System;

namespace WM_ControlIngreso_Api.Models.Entities
{
    public class DetalleInsumo
    {
        public int IdDetalleInsumo { get; set; }
        public int IdInsumo { get; set; }
        public int IdRaciones { get; set; }
        public decimal? CantidadGramos { get; set; }
        public decimal? CantidadKilogramos { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaUpdate { get; set; }

        // Relaciones (opcional)
        public Insumo Insumo { get; set; }
        public Racion Racion { get; set; }
    }
}
