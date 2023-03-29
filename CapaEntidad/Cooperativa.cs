using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cooperativa
    {
        public int IdCooperativa { get; set; }
        public string CodigoCooperativa { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public DateTime InicioOperaciones { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string CorreoElectronico { get; set; }
        public string SitioWeb { get; set; }
        public string Federacion { get; set; }
        public string GerenteGeneral { get; set; }
        public string OtroContacto { get; set; }
        public int NoAgencias { get; set; }
        public string IdDistrito { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
