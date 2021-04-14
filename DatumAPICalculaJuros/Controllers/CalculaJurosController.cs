using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DatumAPICalculaJuros.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DatumAPICalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ILogger<CalculaJurosController> _logger;
        public CalculaJurosController(ILogger<CalculaJurosController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Expõe o get na API para o cálculo do Juros a patir do valor inicial e o tempo.
        /// Retorna o objeto json CalculaJuros com o valor final calculado.
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<CalculaJuros> CalculaJuros(decimal valorInicial, int tempo)
        {            
            CalculaJuros calculaJuros = new CalculaJuros();
            calculaJuros.ValorFinal = calculaJuros.calcularValorJuros(valorInicial, tempo);

            return calculaJuros;
        }

        [HttpGet("error")]
        public IActionResult GetError()
        {
            return Problem("Erro no acesso ao Sistema. Favor entrar em contato com o Administrador.");
        }

    }
}