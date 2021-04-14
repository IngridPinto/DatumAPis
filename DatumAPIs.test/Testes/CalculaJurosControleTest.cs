using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DatumAPICalculaJuros.Model;
using System.Globalization;
using DatumAPICalculaJuros.Controle;

namespace DatumAPIs.test.Testes
{
    public class CalculaJurosControleTest
    {
        private readonly CalculaJurosControle _calculaJurosControle = new CalculaJurosControle();

        [Theory (DisplayName = "Calcula o valor final")]
        [InlineData(100, 5, "0.01", "105.10")]
        public void CalculaJurosControleValorTest(decimal valorInicial, int tempo, string taxa, string resultado)
        {
            CalculaJurosModel calculaJurosModel = new CalculaJurosModel();
            decimal taxaDecimal = Convert.ToDecimal(taxa, CultureInfo.InvariantCulture);
            calculaJurosModel = _calculaJurosControle.CalcularValorJuros(valorInicial, tempo, taxaDecimal);
            decimal expected = Convert.ToDecimal(resultado, CultureInfo.InvariantCulture);

            Assert.Equal(expected, calculaJurosModel.ValorFinal);

        }
    }
}
