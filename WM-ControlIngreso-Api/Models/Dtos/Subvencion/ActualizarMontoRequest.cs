namespace WM_ControlIngreso_Api.Models.Dtos.Subvencion
{
    public class ActualizarMontoRequest
    {
        public int IdComite { get; set; }
        public int IdUsuario { get; set; }
        public decimal Monto { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
    }
}
