using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DatumAPICalculaJuros.Model;
using System.Globalization;

namespace DatumAPIs.test
{
    public class CalculaJurosTest
    {
        [Theory]
        [InlineData(100, 5, "105.10")]
        public void CalcularJurosValorFinalTest(decimal valorInicial, int tempo, string resultado)
        {
            CalculaJuros juros = new CalculaJuros();
            decimal valorDoJuros = juros.calcularValorJuros(valorInicial, tempo);
            decimal expected = Convert.ToDecimal(resultado, CultureInfo.InvariantCulture);
            Assert.Equal(expected, valorDoJuros);

        }
    }
}
