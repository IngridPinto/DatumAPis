using DatumApis.Integracao.test.Fixtures;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DatumApis.Integracao.test.Scenarios
{
    public class CalculaJurosIntegrationTest
    {
        private readonly TestContextApiCalculaJuros _testContext;
        public CalculaJurosIntegrationTest()
        {
            _testContext = new TestContextApiCalculaJuros();
        }

        [Theory(DisplayName = "Verifica o método CalculaJuros")]
        [InlineData("100", 5, "105.10")]
        public async Task CalculaJuros_GetCalculaJuros_ReturnsOkResponse(string valorInicial, int tempo, string resultado)
        {
            var response = await _testContext.Client.GetAsync($"/calculajuros?valorinicial={valorInicial}&tempo={tempo}");
            response.EnsureSuccessStatusCode();

            Assert.True(response.IsSuccessStatusCode);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact(DisplayName = "Verifica o método ShowMeTheCode")]
        public async Task ShowMeTheCode_Get_ReturnsOkResponse()
        {
            var response = await _testContext.Client.GetAsync("/showmethecode");
            response.EnsureSuccessStatusCode();

            Assert.True(response.IsSuccessStatusCode);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
