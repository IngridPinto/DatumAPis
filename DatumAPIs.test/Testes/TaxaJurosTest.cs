using System;
using Xunit;
using DatumApiTaxaJuros.Model;

namespace DatumAPIs.test.Testes
{
    public class TaxaJurosTest
    {
        private readonly TaxaJuros taxaJuros = new TaxaJuros();

        [Fact (DisplayName = "ValorTaxaJuros - Retorna taxa a partir da classe TaxaJuros")]
        public void ValorTaxaJuros()
        {            
            Assert.Equal(0.01m, taxaJuros.ValorTaxaJuros);
        }
    }
}
