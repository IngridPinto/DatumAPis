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

        [Theory (DisplayName = "CalculaJurosControleValorTest - Calcula o valor final no controle")]
        [InlineData("100", 5, "0.01", "105.10")]
        [InlineData("150", 8, "0.01", "162.43")]
        [InlineData("463.14", 8, "0.01", "501.51")]
        public void CalculaJurosControleValorTest(string valorInicial, int tempo, string taxa, string resultado)
        {
            CalculaJurosModel calculaJurosModel = new CalculaJurosModel();
            decimal valorInicialDecimal = Convert.ToDecimal(valorInicial, CultureInfo.InvariantCulture);
            decimal taxaDecimal = Convert.ToDecimal(taxa, CultureInfo.InvariantCulture);
            calculaJurosModel = _calculaJurosControle.CalcularValorJuros(valorInicialDecimal, tempo, taxaDecimal);
            decimal expected = Convert.ToDecimal(resultado, CultureInfo.InvariantCulture);

            Assert.Equal(expected, calculaJurosModel.ValorFinal);

        }
    }
}
