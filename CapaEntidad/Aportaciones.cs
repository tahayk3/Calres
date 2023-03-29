using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Aportaciones
    {
        public int IdAportaciones { get; set; }
        public decimal SaldoInicial { get; set; }
        public DateTime FechaEvaluacion { get; set; }
        public decimal EneroProyectado { get; set; }
        public decimal FebreroProyectado { get; set; }
        public decimal MarzoProyectado { get; set; }
        public decimal AbrilProyectado { get; set; }
        public decimal MayoProyectado { get; set; }
        public decimal JunioProyectado  { get; set; }
        public decimal JulioProyectado { get; set; }
        public decimal AgostoProyectado { get; set; }
        public decimal SeptiembreProyectado { get; set; }
        public decimal OctubreProyectado { get; set; }
        public decimal NoviembreProyectado { get; set; }
        public decimal DiciembreProyectado { get; set; }
        public decimal CrecimientoProyectado { get; set; }
        public decimal EneroEjecutado { get; set; }
        public decimal FebreroEjecutado { get; set; }
        public decimal MarzoEjecutado { get; set; }
        public decimal AbrilEjecutado { get; set; }
        public decimal MayoEjecutado { get; set; }
        public decimal JunioEjecutado { get; set; }
        public decimal JulioEjecutado { get; set; }
        public decimal AgostoEjecutado { get; set; }
        public decimal SeptiembreEjecutado { get; set; }
        public decimal OctubreEjecutado { get; set; }
        public decimal NoviembreEjecutado { get; set; }
        public decimal DiciembreEjecutado { get; set; }
        public decimal EneroPorcentaje { get; set; }
        public decimal FebreroPorcentaje { get; set; }
        public decimal MarzoPorcentaje { get; set; }
        public decimal AbrilPorcentaje { get; set; }
        public decimal MayoPorcentaje { get; set; }
        public decimal JunioPorcentaje { get; set; }
        public decimal JulioPorcentaje { get; set; }
        public decimal AgostoPorcentaje { get; set; }
        public decimal SeptiembrePorcentaje { get; set; }
        public decimal OctubrePorcentaje { get; set; }
        public decimal NoviembrePorcentaje { get; set; }
        public decimal DiciembrePorcentaje { get; set; }
        public Usuario oUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
