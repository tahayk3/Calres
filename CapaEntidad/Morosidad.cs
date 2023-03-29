using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Morosidad
    {
        public int IdMorosidad { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal AgriculturaUnoTres { get; set; }
        public decimal ComercioUnoTres { get; set; }
        public decimal ServiciosUnotres { get; set; }
        public decimal IndustriaUnoTres { get; set; }
        public decimal ViviendaUnoTres { get; set; }
        public decimal ConsumoUnoTres { get; set; }
        public decimal TotalUnoTres { get; set; }
        public int MorososUnoTres { get; set; }
        public decimal IndiceUnoTres { get; set; }
        public decimal CoberturaUnoTres { get; set; }
        public decimal EstimacionUnoTres { get; set; }
        public decimal AgriculturaCuatroSeis { get; set; }
        public decimal ComercioCuatroSeis { get; set; }
        public decimal ServiciosCuatroSeis { get; set; }
        public decimal IndustriaCuatroSeis { get; set; }
        public decimal ViviendaCuatroSeis { get; set; }
        public decimal ConsumoCuatroSeis { get; set; }
        public decimal TotalCuatroSeis { get; set; }
        public int MorososCuatroSeis { get; set; }
        public decimal IndiceCuatroSeis { get; set; }
        public decimal CoberturaCuatroSeis { get; set; }
        public decimal EstimacionCuatroSeis { get; set; }
        public decimal CarteraMenorDoce { get; set; }
        public decimal AgriculturaSieteDoce { get; set; }
        public decimal ComercioSieteDoce { get; set; }
        public decimal ServiciosSieteDoce { get; set; }
        public decimal IndustriaSieteDoce { get; set; }
        public decimal ViviendaSieteDoce { get; set; }
        public decimal ConsumoSieteDoce { get; set; }
        public decimal TotalSieteDoce { get; set; }
        public int MorososSieteDoce { get; set; }
        public decimal IndiceSieteDoce { get; set; }
        public decimal CoberturaSieteDoce { get; set; }
        public decimal EstimacionSieteDoce { get; set; }
        public decimal AgriculturaMayorDoce { get; set; }
        public decimal ComercioMayorDoce { get; set; }
        public decimal ServiciosMayorDoce { get; set; }
        public decimal IndustriaMayorDoce { get; set; }
        public decimal ViviendaMayorDoce { get; set; }
        public decimal ConsumoMayorDoce { get; set; }
        public decimal TotalMayorDoce { get; set; }
        public int MorososMayorDoce { get; set; }
        public decimal IndiceMayorDoce { get; set; }
        public decimal CoberturaMayorDoce { get; set; }
        public decimal EstimacionMayorDoce { get; set; }
        public decimal CarteraMayorDoce { get; set; }
        public decimal AgriculturaTotalMora { get; set; }
        public decimal ComercioTotalMora { get; set; }
        public decimal ServiciosTotalMora { get; set; }
        public decimal IndustriaTotalMora { get; set; }
        public decimal ViviendaTotalMora { get; set; }
        public decimal ConsumoTotalMora { get; set; }
        public decimal TotalMora { get; set; }
        public int MorososTotal { get; set; }
        public decimal IndiceTotal { get; set; }
        public decimal CoberturaTotalMora { get; set; }
        public decimal EstimacionTotalMora { get; set; }
        public decimal CarteraTotalMora { get; set; }
        public decimal AgriculturaSana { get; set; }
        public decimal ComercioSana { get; set; }
        public decimal ServiciosSana { get; set; }
        public decimal IndustriaSana { get; set; }
        public decimal ViviendaSana { get; set; }
        public decimal ConsumoSana { get; set; }
        public decimal TotalSana { get; set; }
        public int AsociadosSana { get; set; }
        public decimal IndiceSana { get; set; }
        public decimal TotalCartera { get; set; }
        public Usuario oUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
