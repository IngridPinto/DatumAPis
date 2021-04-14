using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatumApiTaxaJuros.Model;
using Microsoft.AspNetCore.Http;

namespace DatumApiTaxaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ILogger<TaxaJurosController> _logger;

        public TaxaJurosController(ILogger<TaxaJurosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<TaxaJuros> GetTaxa()
        {
            TaxaJuros taxa = new TaxaJuros();

            return Ok(taxa);
        }

        [HttpGet("error")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetError()
        {
            return Problem("Erro no acesso ao Sistema. Favor entrar em contato com o Administrador.");
        }
    }
}
