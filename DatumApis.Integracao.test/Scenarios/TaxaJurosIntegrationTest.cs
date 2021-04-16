using DatumApis.Integracao.test.Fixtures;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DatumApis.Integracao.test.Scenarios
{
    public class TaxaJurosIntegrationTest
    {
        private readonly TestContextApiTaxaJuros _testContext;
        public TaxaJurosIntegrationTest()
        {
            _testContext = new TestContextApiTaxaJuros();
        }

        [Fact(DisplayName = "Retorna a taxa de juros")]
        public async Task TaxaJuros_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/taxajuros");
            response.EnsureSuccessStatusCode();

            Assert.True(response.IsSuccessStatusCode);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
