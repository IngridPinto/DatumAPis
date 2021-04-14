using System;
using Xunit;
using DatumApiTaxaJuros.Model;

namespace DatumAPIs.test.Testes
{
    public class TaxaJurosTest
    {
        private readonly TaxaJuros taxaJuros = new TaxaJuros();

        [Fact]
        public void ValorTaxaJuros()
        {            
            Assert.Equal(0.01m, taxaJuros.ValorTaxaJuros);
        }
    }
}
