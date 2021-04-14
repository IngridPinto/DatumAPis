using DatumAPICalculaJuros.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DatumAPICalculaJuros.Controle
{
    public class CalculaJurosControle
    {
        /// <summary>
        /// Calcula o valor final a partir do valor inicial e do tempo usando o calculo:
        /// ValorFinal = ValorInicial * (1 + juros) ^ tempo
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        public CalculaJurosModel CalcularValorJuros(decimal valorInicial, int tempo, decimal taxaJuros)
        {
            CalculaJurosModel calculaJurosModel = new CalculaJurosModel
            {
                ValorInicial = valorInicial,
                Tempo = tempo,
                Taxa = taxaJuros
            };

            try
            {
                double juros = decimal.ToDouble(calculaJurosModel.Taxa + 1) ;

                //"Truncate" sem arrendondamento"
                string valorString = (valorInicial * 
                    Convert.ToDecimal(Math.Pow(juros, tempo), CultureInfo.InvariantCulture))
                    .ToString("0.00");

                calculaJurosModel.ValorFinal = Convert.ToDecimal(valorString);

                return calculaJurosModel;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
