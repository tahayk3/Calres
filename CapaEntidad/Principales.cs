using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Principales
    {
        public int IdPrincipales { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal PrestamosUno { get; set; }
        public decimal InverLiquidasUno { get; set; }
        public decimal InverFinanUno { get; set; }
        public decimal InverNoFinanUno { get; set; }
        public decimal ImproductivosUno { get; set; }
        public decimal TotalActivoUno { get; set; }
        public decimal PrestamosDos { get; set; }
        public decimal InverLiquidasDos { get; set; }
        public decimal InverFinanDos { get; set; }
        public decimal InverNoFinanDos { get; set; }
        public decimal ImproductivosDos { get; set; }
        public decimal TotalActivosDos { get; set; }
        public decimal DepositosUno { get; set; }
        public decimal CreditoExternoUno { get; set; }
        public decimal PasivosSinCostoUno { get; set; }
        public decimal AportacionesUno { get; set; }
        public decimal CapitalUno { get; set; }
        public decimal TotalPasivoUno { get; set; }
        public decimal DepositosDos { get; set; }
        public decimal CreditoExternoDos { get; set; }
        public decimal PasivosSinCostoDos { get; set; }
        public decimal AportacionesDos { get; set; }
        public decimal CapitalDos { get; set; }
        public decimal TotalPasivoDos { get; set; }
        public Usuario oUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
