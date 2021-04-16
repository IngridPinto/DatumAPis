using DatumApiTaxaJuros;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DatumApis.Integracao.test.Fixtures
{
    public class TestContextApiTaxaJuros
    {
        public HttpClient Client { get; set; }

        private TestServer _server;
        public TestContextApiTaxaJuros()
        {
            SetupClient();
        }
        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>())
            {
                BaseAddress = new Uri("http://localhost:57409")
            };
            Client = _server.CreateClient();
        }

    }
}
