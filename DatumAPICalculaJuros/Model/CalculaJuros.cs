using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DatumAPICalculaJuros.Model
{
    public class CalculaJuros
    {
        public CalculaJuros()
        {

        }

        public decimal ValorInicial { get; set; }
        public decimal ValorFinal { get; set; }
        public int Tempo { get; set; }
        public decimal Taxa { get; set; }

        /// <summary>
        /// Calcula o valor final a partir do valor inicial e do tempo usando o calculo:
        /// ValorFinal = ValorInicial * (1 + juros) ^ tempo
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public decimal calcularValorJuros(decimal valorInicial, int tempo)
        {
            ValorInicial = valorInicial;
            Tempo = tempo;

            try
            {
                Taxa = DatumAPITaxaJuros.getTaxa();

                double juros = decimal.ToDouble(Taxa + 1);

                ValorFinal = valorInicial * Convert.ToDecimal(Math.Pow(juros, tempo), CultureInfo.InvariantCulture);

                return ValorFinal;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}