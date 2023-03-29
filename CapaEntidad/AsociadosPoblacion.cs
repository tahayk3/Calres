using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AsociadosPoblacion
    {
        public int IdAsociadosPoblacion { get; set; }
        public DateTime FechaEvaluacion { get; set; }
        public decimal PibUno { get; set; }
        public decimal PibDos { get; set; }
        public decimal PibTres { get; set; }
        public decimal PibCuatro { get; set; }
        public decimal PibTotal { get; set; }
        public decimal AsociadosUno { get; set; }
        public decimal AsociadosDos { get; set; }
        public decimal AsociadosTres { get; set; }
        public decimal AsociadosCuatro { get; set; }
        public decimal AsociadosTotal { get; set; }
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
