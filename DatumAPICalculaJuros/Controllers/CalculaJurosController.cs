using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DatumAPICalculaJuros.Model;
using DatumAPICalculaJuros.Interface;
using DatumAPICalculaJuros.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using DatumAPICalculaJuros.Controle;

namespace DatumAPICalculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly ILogger<CalculaJurosController> _logger;

        private readonly IDatumAPITaxaJurosService _datumAPITaxaJurosService;

        private readonly CalculaJurosControle _calculaJurosControle;

        public CalculaJurosController(IDatumAPITaxaJurosService datumAPITaxaJurosService)
        {
            _datumAPITaxaJurosService = datumAPITaxaJurosService;
            _calculaJurosControle = new CalculaJurosControle();
        }

        /// <summary>
        /// Expõe o get na API para o cálculo do Juros a patir do valor inicial e o tempo.
        /// Retorna o objeto json CalculaJuros com o valor final calculado.
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public CalculaJurosModel CalculaJuros(decimal valorInicial, int tempo)
        {            
            decimal taxa = _datumAPITaxaJurosService.GetTaxa();
            CalculaJurosModel calculaJuros = _calculaJurosControle.CalcularValorJuros(valorInicial, tempo, taxa);

            return calculaJuros;
        }

        [HttpGet("error")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetError()
        {
            return Problem("Erro no acesso ao Sistema. Favor entrar em contato com o Administrador.");
        }

    }
}