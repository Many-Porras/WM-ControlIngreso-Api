namespace WM_ControlIngreso_Api.Models.Dtos.Subvencion
{
    public class SubvencionResponse
    {
        public string Region { get; set; }
        public string Provincia { get; set; }
        public string Distrito { get; set; }
        public string Colegio { get; set; }
        public int idComite { get; set; }
        public string Comite { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
    }
}
