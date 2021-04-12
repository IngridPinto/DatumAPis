using System;
using Xunit;
using DatumApiTaxaJuros.Model;

namespace DatumAPIs.test
{
    public class TaxaJurosTest
    {
        [Fact]
        public void ValorTaxaJuros()
        {
            TaxaJuros taxaJuros = new TaxaJuros();
            Assert.Equal(0.01m, taxaJuros.ValorTaxaJuros);
        }
    }
}
