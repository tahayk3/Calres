using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Domicilio { get; set; }
        public string TelefonoDomiciliar { get; set; }
        public string TelefonoPersonal { get; set; }
        public string Correo { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaNacimiento { get; set; }
        public string EstadoCivil { get; set; }
        public string Contacto { get; set; }
        public int NoHijos { get; set; }
        public string NombreMadre { get; set; }
        public string NombrePadre { get; set; }
        public string TipoSangre { get; set; }
        public string Clave { get; set; }
        public Rol oRol { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
