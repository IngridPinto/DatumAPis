using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DatumApiTaxaJuros.Model;

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
        public ActionResult<TaxaJuros> GetTaxa()
        {
            TaxaJuros taxa = new TaxaJuros();

            return taxa;
        }

        [HttpGet("error")]
        public IActionResult GetError()
        {
            return Problem("Erro no acesso ao Sistema. Favor entrar em contato com o Administrador.");
        }
    }
}
