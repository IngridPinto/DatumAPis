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
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public TaxaJuros GetTaxa()
        {
            TaxaJuros Taxa = new TaxaJuros();

            return Taxa;
        }

        //[HttpGet("error")]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public IActionResult GetError()
        //{
        //    return Problem("Erro no acesso ao Sistema. Favor entrar em contato com o Administrador.");
        //}
    }
}
