using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AsociadosAhorros
    {
        public int IdAsociadosAhorros { get; set; }
        public DateTime FechaEvaluacion { get; set; }
        public decimal AhorrosSistemaUno { get; set; }
        public decimal AhorrosSistemaDos { get; set; }
        public decimal AhorrosSistemaTres { get; set; }
        public decimal AhorrosSistemaCuatro { get; set; }
        public decimal AhorrosSistemaTotal { get; set; }
        public decimal AhorroCoopeUno { get; set; }
        public decimal AhorroCoopeDos { get; set; }
        public decimal AhorroCoopeTres { get; set; }
        public decimal AhorroCoopeCuatro { get; set; }
        public decimal AhorroCoopeTotal { get; set; }
        public decimal MercadoPotencialUno { get; set; }
        public decimal MercadoPotencialDos { get; set; }
        public decimal MercadoPotencialTres { get; set; }
        public decimal MercadoPotencialCuatro { get; set; }
        public decimal MercadoPotencialTotal { get; set; }
        public decimal IngresoMercadoUno { get; set; }
        public decimal IngresoMercadoDos { get; set; }
        public decimal IngresoMercadoTres { get; set; }
        public decimal IngresoMercadoCuatro { get; set; }
        public decimal IngresoMercadoTotal { get; set; }
        public Usuario oUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
