namespace WM_ControlIngreso_Api.Models.Dtos.Subvencion
{
    public class RegistrarMontoRequest
    {
        public int IdComite { get; set; }
        public int IdUsuario { get; set; }
        public decimal Monto { get; set; }
    }
}
