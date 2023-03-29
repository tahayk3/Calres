using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class InfoSectorFinan
    {
        public int IdInfoSectorFinan { get; set; }
        public DateTime FechaInformacion { get; set; }
        public decimal TasaActivaPonde { get; set; }
        public decimal TasaPasivaPonde { get; set; }
        public decimal TasaDPFPonde { get; set; }
        public decimal TasaInflacion { get; set; }
        public decimal TasaCambio { get; set; }
        public decimal IndicePrecioConsumidor { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
