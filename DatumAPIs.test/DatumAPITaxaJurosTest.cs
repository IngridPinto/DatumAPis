using DatumAPICalculaJuros.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DatumAPIs.test
{
    public class DatumAPITaxaJurosTest
    {
        [Fact]
        public void getTaxaTest()
        {            
            decimal resultado = DatumAPITaxaJuros.getTaxa();

            Assert.Equal(0.01m, resultado);
        }
    }
}
