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
        [HttpGet]
        public decimal GetTaxa()
        {
            TaxaJuros taxa = new TaxaJuros();

            return taxa.ValorTaxaJuros;

        }
    }
}
