using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Indicadores
    {
        public int IdIndicadores { get; set; }
        public DateTime FechaInformacion { get; set; }
        public decimal TotalActivos { get; set; }
        public decimal CarteraNetaPrestamos { get; set; }
        public decimal InversionesLiquidas { get; set; }
        public decimal InversionesFinancieras { get; set; }
        public decimal InverNoFinancieras { get; set; }
        public decimal DepositosAhorro { get; set; }
        public decimal CreditoExterno { get; set; }
        public decimal Aportaciones { get; set; }
        public decimal CapitalInstitucional { get; set; }
        public decimal CapitalInstitucionalNeto { get; set; }
        public decimal Asociados { get; set; }
        public decimal Morosidad { get; set; }
        public decimal ActivoImproductivo { get; set; }
        public decimal FondosSinCosto { get; set; }
        public decimal Disponibilidades { get; set; }
        public decimal ReservasLiquidez { get; set; }
        public decimal LiquidezOciosa { get; set; }
        public decimal IngresosPrestamos { get; set; }
        public decimal IngresosInverLiquidas { get; set; }
        public decimal IngresosInverFinan { get; set; }
        public decimal IngresosInverNoFinan { get; set; }
        public decimal CostosDepositos { get; set; }
        public decimal CostosCreditoExterno { get; set; }
        public decimal CostosAportaciones { get; set; }
        public decimal MargenBruto { get; set; }
        public decimal GastosOperativos { get; set; }
        public decimal Provisiones { get; set; }
        public decimal OtrosIngresosGastos { get; set; }
        public decimal ExcedenteNeto { get; set; }
        public decimal EstrucPrestamos { get; set; }
        public decimal EstrucInverLiquidas { get; set; }
        public decimal EstrucInverFinancieras { get; set; }
        public decimal EstrucInverNoFinan { get; set; }
        public decimal EstrucDepoAhorros { get; set; }
        public decimal EstrucCreditoExterno { get; set; }
        public decimal EstrucAportaciones { get; set; }
        public decimal EstrucCapitalInstitu { get; set; }
        public decimal EstrucCapitalInstituNeto { get; set; }
        public decimal Estimaciones { get; set; }
        public decimal EstimacionesNetas { get; set; }
        public decimal DepuracionCompleta { get; set; }
        public decimal DepuracionAnual { get; set; }
        public decimal RecuperacionDepura { get; set; }
        public decimal Solvencia { get; set; }
        public decimal EstimInversiones { get; set; }
        public decimal EstimExtraordinarios { get; set; }
        public Usuario oUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
