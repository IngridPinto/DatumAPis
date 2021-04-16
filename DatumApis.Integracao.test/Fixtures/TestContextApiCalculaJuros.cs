using DatumAPICalculaJuros;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DatumApis.Integracao.test.Fixtures
{
    public class TestContextApiCalculaJuros
    {
        public HttpClient Client { get; set; }

        private TestServer _server;
        public TestContextApiCalculaJuros()
        {
            SetupClient();
        }
        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>())
            {
                BaseAddress = new Uri("http://localhost:44309")
            };

            Client = _server.CreateClient();
        }
    }
}
