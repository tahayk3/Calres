using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Agencia
    {
        public int IdAgencia { get; set; }
        public string CodigoAgencia { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime InicioOperaciones { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string CorreoElectronico { get; set; }
        public string SitioWeb { get; set; }
        public string Gerente { get; set; }
        public string OtroContacto { get; set; }
        public string IdDistrito { get; set; }
        public Cooperativa oCooperativa { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
