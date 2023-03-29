using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Membresia
    {
        public int IdMembresia { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int InicialMujer { get; set; }
        public int IngresoMujer { get; set; }
        public int SubIngresoMujer { get; set; }
        public int EgresoMujer { get; set; }
        public int SubEgresoMujer { get; set; }
        public int IngresoNetoMujer { get; set; }
        public int SaldoFinalMujer { get; set; }
        public int InicialHombre { get; set; }
        public int IngresoHombre { get; set; }
        public int SubIngresoHombre { get; set; }
        public int EgresoHombre { get; set; }
        public int SubEgresoHombre { get; set; }
        public int IngresoNetoHombre { get; set; }
        public int SaldoFinalHombre { get; set; }
        public int InicialNinia { get; set; }
        public int IngresoNinia { get; set; }
        public int SubIngresoNinia { get; set; }
        public int EgresoNinia { get; set; }
        public int SubEgresoNinia { get; set; }
        public int IngresoNetoNinia { get; set; }
        public int SaldoFinalNinia { get; set; }
        public int InicialNinio { get; set; }
        public int IngresoNinio { get; set; }
        public int SubIngresoNinio { get; set; }
        public int EgresoNinio { get; set; }
        public int SubEgresoNinio { get; set; }
        public int IngresoNetoNinio { get; set; }
        public int SaldoFinalNinio { get; set; }
        public int InicialTerceros { get; set; }
        public int IngresoTerceros { get; set; }
        public int SubIngresoTerceros { get; set; }
        public int EgresoTerceros { get; set; }
        public int SubEgresoTerceros { get; set; }
        public int IngresoNetoTerceros { get; set; }
        public int SaldoFinalTerceros { get; set; }
        public int InicialTotal { get; set; }
        public int IngresoTotal { get; set; }
        public int SubIngresoTotal { get; set; }
        public int EgresoTotal { get; set; }
        public int SubEgresoTotal { get; set; }
        public int IngresoNetoTotal { get; set; }
        public int SaldoFinalTotal { get; set; }
        public Usuario oUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
